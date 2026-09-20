import re
from PyQt6.QtCore import Qt, QRegularExpression
from PyQt6.QtGui import QColor, QFont, QSyntaxHighlighter, QTextCharFormat
from PyQt6.QtWidgets import QPlainTextEdit, QWidget, QVBoxLayout

class SimpleSyntaxHighlighter(QSyntaxHighlighter):
    """Bộ tô màu cú pháp nhẹ cho C#, Java, Python."""

    def __init__(self, parent=None, language="csharp"):
        super().__init__(parent)
        self.language = language
        self.highlighting_rules = []

        # Định dạng từ khóa (Keywords)
        keyword_format = QTextCharFormat()
        keyword_format.setForeground(QColor("#0066CC"))
        keyword_format.setFontWeight(QFont.Weight.Bold)

        keywords_csharp = [
            r"\bclass\b", r"\bpublic\b", r"\bprivate\b", r"\bprotected\b", r"\binternal\b",
            r"\bstatic\b", r"\bvoid\b", r"\bstring\b", r"\bint\b", r"\bbool\b", r"\bvar\b",
            r"\breturn\b", r"\bif\b", r"\belse\b", r"\bfor\b", r"\bforeach\b", r"\bwhile\b",
            r"\bnew\b", r"\bnamespace\b", r"\busing\b", r"\btry\b", r"\bcatch\b", r"\bfinally\b"
        ]

        keywords_python = [
            r"\bdef\b", r"\bclass\b", r"\bimport\b", r"\bfrom\b", r"\bas\b", r"\breturn\b",
            r"\bif\b", r"\belif\b", r"\belse\b", r"\bfor\b", r"\bwhile\b", r"\btry\b",
            r"\bexcept\b", r"\bfinally\b", r"\bwith\b", r"\bTrue\b", r"\bFalse\b", r"\bNone\b"
        ]

        keywords = keywords_csharp if language in ["csharp", "java"] else keywords_python
        for pattern in keywords:
            self.highlighting_rules.append((QRegularExpression(pattern), keyword_format))

        # Chuỗi (Strings)
        string_format = QTextCharFormat()
        string_format.setForeground(QColor("#A31515"))
        self.highlighting_rules.append((QRegularExpression(r'".*?"'), string_format))

        # Chú thích (Comments)
        comment_format = QTextCharFormat()
        comment_format.setForeground(QColor("#008000"))
        self.highlighting_rules.append((QRegularExpression(r"//[^\n]*"), comment_format))
        self.highlighting_rules.append((QRegularExpression(r"#[^\n]*"), comment_format))

    def highlightBlock(self, text):
        for pattern, fmt in self.highlighting_rules:
            match_iterator = pattern.globalMatch(text)
            while match_iterator.hasNext():
                match = match_iterator.next()
                self.setFormat(match.capturedStart(), match.capturedLength(), fmt)


class CodeViewerWidget(QWidget):
    """Widget hiển thị mã nguồn với font monospace và tô màu cú pháp."""

    def __init__(self, parent=None):
        super().__init__(parent)
        layout = QVBoxLayout(self)
        layout.setContentsMargins(0, 0, 0, 0)

        self.editor = QPlainTextEdit()
        self.editor.setReadOnly(True)
        self.editor.setFont(QFont("Consolas", 10))
        self.editor.setStyleSheet(
            """
            QPlainTextEdit {
                background-color: #FFFFFF;
                color: #1E293B;
                border: 1px solid #E2E8F0;
                border-radius: 4px;
                padding: 8px;
            }
            """
        )

        layout.addWidget(self.editor)
        self.highlighter = SimpleSyntaxHighlighter(self.editor.document(), "csharp")

    def set_code(self, code_text: str, language: str = "csharp"):
        self.editor.setPlainText(code_text)
        self.highlighter = SimpleSyntaxHighlighter(self.editor.document(), language)
        self.highlighter.rehighlight()

    def go_to_line(self, line_number: int):
        """Di chuyển con trỏ và cuộn tới dòng chỉ định (1-indexed)."""
        doc = self.editor.document()
        if line_number < 1 or line_number > doc.blockCount():
            return

        block = doc.findBlockByLineNumber(line_number - 1)
        cursor = self.editor.textCursor()
        cursor.setPosition(block.position())
        self.editor.setTextCursor(cursor)
        self.editor.centerCursor()

    def clear(self):
        self.editor.clear()
