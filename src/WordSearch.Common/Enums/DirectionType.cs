namespace WordSearch.Common.Enums
{
    /// <summary>
    /// Тип направления
    /// </summary>
    public enum DirectionType
    {
        /// <summary>
        /// Слева направо
        /// </summary>
        LeftToRight,
        
        /// <summary>
        /// Справа налево
        /// </summary>
        RightToLeft,
        
        /// <summary>
        /// Сверху вниз
        /// </summary>
        TopToBottom,
        
        /// <summary>
        /// Снизу вверх
        /// </summary>
        BottomToTop,
        
        /// <summary>
        /// От верхнего левого до нижнего правого края
        /// </summary>
        TopLeftToBottomRight,
        
        /// <summary>
        /// От нижнего правого до верхнего левого края
        /// </summary>
        BottomRightToTopLeft,
        
        /// <summary>
        /// От нижнего левого до верхнего правого края
        /// </summary>
        BottomLeftToTopRight,
        
        /// <summary>
        /// От верхнего правого до нижнего левого края
        /// </summary>
        TopRightToBottomLeft
    }
}
