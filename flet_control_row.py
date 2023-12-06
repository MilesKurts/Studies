import flet as ft

def main(page: ft.page):
    page.add(
        ft.Row(controls=[
            ft.Text("Please"),
            ft.Text("don't"),
            ft.Text("Do")
        ])
    )

ft.app(target=main)