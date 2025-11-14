using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3118 - .
/// </summary>
public class F3118 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WNMMCU.
        /// </summary>
        public const string WNMMCU = "WNMMCU";

        /// <summary>
        /// WNITM.
        /// </summary>
        public const string WNITM = "WNITM";

        /// <summary>
        /// WNDOCO.
        /// </summary>
        public const string WNDOCO = "WNDOCO";

        /// <summary>
        /// WNDCTO.
        /// </summary>
        public const string WNDCTO = "WNDCTO";

        /// <summary>
        /// WNDRQJ.
        /// </summary>
        public const string WNDRQJ = "WNDRQJ";

        /// <summary>
        /// WNUORG.
        /// </summary>
        public const string WNUORG = "WNUORG";

        /// <summary>
        /// WNUM.
        /// </summary>
        public const string WNUM = "WNUM";

        /// <summary>
        /// WNTRDJ.
        /// </summary>
        public const string WNTRDJ = "WNTRDJ";

        /// <summary>
        /// WNMCU.
        /// </summary>
        public const string WNMCU = "WNMCU";

        /// <summary>
        /// WNRKCO.
        /// </summary>
        public const string WNRKCO = "WNRKCO";

        /// <summary>
        /// WNRORN.
        /// </summary>
        public const string WNRORN = "WNRORN";

        /// <summary>
        /// WNRCTO.
        /// </summary>
        public const string WNRCTO = "WNRCTO";

        /// <summary>
        /// WNRLLN.
        /// </summary>
        public const string WNRLLN = "WNRLLN";

        /// <summary>
        /// WNDRQ2.
        /// </summary>
        public const string WNDRQ2 = "WNDRQ2";

        /// <summary>
        /// WNSTKT.
        /// </summary>
        public const string WNSTKT = "WNSTKT";

        /// <summary>
        /// WNAITM.
        /// </summary>
        public const string WNAITM = "WNAITM";

        /// <summary>
        /// WNLITM.
        /// </summary>
        public const string WNLITM = "WNLITM";
    }

    /// <inheritdoc />
    public override string TableName => "F3118";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WNMMCU", "WNMMCU", JdeDataType.String, 24, true, true),
        new JdeField("WNITM", "WNITM", JdeDataType.Numeric, null, true, true),
        new JdeField("WNDOCO", "WNDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("WNDCTO", "WNDCTO", JdeDataType.String, 4, true, true),
        new JdeField("WNDRQJ", "WNDRQJ", JdeDataType.Numeric, null, true, true),
        new JdeField("WNUORG", "WNUORG", JdeDataType.Numeric),
        new JdeField("WNUM", "WNUM", JdeDataType.String, 4),
        new JdeField("WNTRDJ", "WNTRDJ", JdeDataType.Numeric),
        new JdeField("WNMCU", "WNMCU", JdeDataType.String, 24, true, true),
        new JdeField("WNRKCO", "WNRKCO", JdeDataType.String, 10),
        new JdeField("WNRORN", "WNRORN", JdeDataType.String, 16),
        new JdeField("WNRCTO", "WNRCTO", JdeDataType.String, 4),
        new JdeField("WNRLLN", "WNRLLN", JdeDataType.Numeric),
        new JdeField("WNDRQ2", "WNDRQ2", JdeDataType.Numeric),
        new JdeField("WNSTKT", "WNSTKT", JdeDataType.String, 2),
        new JdeField("WNAITM", "WNAITM", JdeDataType.String, 50),
        new JdeField("WNLITM", "WNLITM", JdeDataType.String, 50)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3118_0", "Primary Key on WNMMCU, WNITM, WNDOCO, WNDCTO, WNDRQJ, WNMCU", new[] { "WNMMCU", "WNITM", "WNDOCO", "WNDCTO", "WNDRQJ", "WNMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
