import os
import flet as ft

os.environ["FLET_WS_MAX_MESSAGE_SIZE"] = "8000000"

def main(page: ft.Page):
    r = ft.Row(wrap=True, scroll="always", expand=True)
    page.add(r)

    for i in range(25):
        r.controls.append(
            ft.Container(
                ft.Text(f"Item {i}"),
                width=200,
                height=150,
                alignment=ft.alignment.center,
                bgcolor=ft.colors.BLACK,
                border=ft.border.all(1, ft.colors.AMBER_400),
                border_radius=ft.border_radius.all(5),
            )
        )
    page.update()

ft.app(target=main, view=ft.AppView.WEB_BROWSER)