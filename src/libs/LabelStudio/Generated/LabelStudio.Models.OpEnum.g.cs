
#nullable enable

namespace LabelStudio
{
    /// <summary>
    /// * `add_page` - add_page<br/>
    /// * `delete_page` - delete_page<br/>
    /// * `duplicate_page` - duplicate_page<br/>
    /// * `reorder_pages` - reorder_pages<br/>
    /// * `move_page` - move_page<br/>
    /// * `add_module` - add_module<br/>
    /// * `delete_module` - delete_module<br/>
    /// * `duplicate_module` - duplicate_module<br/>
    /// * `reorder_modules` - reorder_modules<br/>
    /// * `rename_module` - rename_module
    /// </summary>
    public enum OpEnum
    {
        /// <summary>
        /// 
        /// </summary>
        AddModule,
        /// <summary>
        /// 
        /// </summary>
        AddPage,
        /// <summary>
        /// 
        /// </summary>
        DeleteModule,
        /// <summary>
        /// 
        /// </summary>
        DeletePage,
        /// <summary>
        /// 
        /// </summary>
        DuplicateModule,
        /// <summary>
        /// 
        /// </summary>
        DuplicatePage,
        /// <summary>
        /// 
        /// </summary>
        MovePage,
        /// <summary>
        /// 
        /// </summary>
        RenameModule,
        /// <summary>
        /// 
        /// </summary>
        ReorderModules,
        /// <summary>
        /// 
        /// </summary>
        ReorderPages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpEnum value)
        {
            return value switch
            {
                OpEnum.AddModule => "add_module",
                OpEnum.AddPage => "add_page",
                OpEnum.DeleteModule => "delete_module",
                OpEnum.DeletePage => "delete_page",
                OpEnum.DuplicateModule => "duplicate_module",
                OpEnum.DuplicatePage => "duplicate_page",
                OpEnum.MovePage => "move_page",
                OpEnum.RenameModule => "rename_module",
                OpEnum.ReorderModules => "reorder_modules",
                OpEnum.ReorderPages => "reorder_pages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpEnum? ToEnum(string value)
        {
            return value switch
            {
                "add_module" => OpEnum.AddModule,
                "add_page" => OpEnum.AddPage,
                "delete_module" => OpEnum.DeleteModule,
                "delete_page" => OpEnum.DeletePage,
                "duplicate_module" => OpEnum.DuplicateModule,
                "duplicate_page" => OpEnum.DuplicatePage,
                "move_page" => OpEnum.MovePage,
                "rename_module" => OpEnum.RenameModule,
                "reorder_modules" => OpEnum.ReorderModules,
                "reorder_pages" => OpEnum.ReorderPages,
                _ => null,
            };
        }
    }
}