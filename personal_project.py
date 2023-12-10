import flet as ft

def main(page):

    page.title = "Cash Register Entrace"
    page.scroll ="adptive"
    title_main = ft.Text(
        value="Casher Register",
        color="green",
        text_align= ft.TextAlign.CENTER,
        width=1500,
        height=50,
        size=30,
        )
    page.add(title_main)
    page.update()

    c1 = ft.Container(
        content=ft.TextField(label="Operator Name"),
        width=300,
        height=100,
    )
    c2 = ft.Container(
        content=ft.TextField(label="Casher Code"),
        width=300,
        height=100,
    )
    page.add(c1, c2)
ft.app(target=main)