# Blazor Headless UI Dropdown

### Installation

`dotnet add package Blazor.HeadlessUI.Dropdown`

Program.cs

`builder.Services.AddDropdownServices();`

Routes.razor

`<SectionOutlet SectionId="FloatingConstants.FloatingSection"/>`

# Examples

```htmlinblazor
<DropdownWrapper @bind-IsOpen="_isOpen"
                 CssClassContainer="dropdown--content--container"
                 CssClassWrapper="dropdown--content__wrapper">
    <TriggerTemplate>
        <button @onclick="TriggerClickHandler" id="@context" class="btn--dropdown">
            @if (_selectedItem is not null)
            {
                <text>@_selectedItem</text>
            }
            else
            {
                <span>Select item</span>
            }
        </button>
    </TriggerTemplate>
    <ContentTemplate>
        <div class="items__wrapper">
            @foreach (var index in Enumerable.Range(0, 10))
            {
                <div class="item" @onclick="() => ItemClickHandler(index)">
                    Item @index
                </div>
            }
        </div>
    </ContentTemplate>
</DropdownWrapper>

@code {

    private int? _selectedItem;
    private bool _isOpen;

    private void TriggerClickHandler()
    {
        _isOpen = true;
        StateHasChanged();
    }

    private void ItemClickHandler(int index)
    {
        _selectedItem = index;
        _isOpen = false;
        StateHasChanged();
    }

}
```

app.css

```css
.dropdown--content--container {
    position: absolute;
    left: -9999px;
    top: -9999px;
    box-sizing: border-box;
    overflow: auto;
    box-shadow: 0 0 16px rgba(0, 0, 0, 0.4);
}

/*...more styles*/
```

# Preview

![record](./media/video.gif)
