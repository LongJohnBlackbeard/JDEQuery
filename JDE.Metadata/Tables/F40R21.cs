using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40R21 - .
/// </summary>
public class F40R21 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// XCMCU.
        /// </summary>
        public const string XCMCU = "XCMCU";

        /// <summary>
        /// XCAN8.
        /// </summary>
        public const string XCAN8 = "XCAN8";

        /// <summary>
        /// XCREQTYP.
        /// </summary>
        public const string XCREQTYP = "XCREQTYP";

        /// <summary>
        /// XCREQFRQ.
        /// </summary>
        public const string XCREQFRQ = "XCREQFRQ";

        /// <summary>
        /// XCDETYP.
        /// </summary>
        public const string XCDETYP = "XCDETYP";

        /// <summary>
        /// XCDEPER.
        /// </summary>
        public const string XCDEPER = "XCDEPER";

        /// <summary>
        /// XCURCD.
        /// </summary>
        public const string XCURCD = "XCURCD";

        /// <summary>
        /// XCURDT.
        /// </summary>
        public const string XCURDT = "XCURDT";

        /// <summary>
        /// XCURAT.
        /// </summary>
        public const string XCURAT = "XCURAT";

        /// <summary>
        /// XCURAB.
        /// </summary>
        public const string XCURAB = "XCURAB";

        /// <summary>
        /// XCURRF.
        /// </summary>
        public const string XCURRF = "XCURRF";

        /// <summary>
        /// XCUSER.
        /// </summary>
        public const string XCUSER = "XCUSER";

        /// <summary>
        /// XCPID.
        /// </summary>
        public const string XCPID = "XCPID";

        /// <summary>
        /// XCJOBN.
        /// </summary>
        public const string XCJOBN = "XCJOBN";

        /// <summary>
        /// XCUPMJ.
        /// </summary>
        public const string XCUPMJ = "XCUPMJ";

        /// <summary>
        /// XCTDAY.
        /// </summary>
        public const string XCTDAY = "XCTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F40R21";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("XCMCU", "XCMCU", JdeDataType.String, 24, true, true),
        new JdeField("XCAN8", "XCAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("XCREQTYP", "XCREQTYP", JdeDataType.String, 6, true, true),
        new JdeField("XCREQFRQ", "XCREQFRQ", JdeDataType.String, 6, true, true),
        new JdeField("XCDETYP", "XCDETYP", JdeDataType.String, 4),
        new JdeField("XCDEPER", "XCDEPER", JdeDataType.String, 4),
        new JdeField("XCURCD", "XCURCD", JdeDataType.String, 4),
        new JdeField("XCURDT", "XCURDT", JdeDataType.Numeric),
        new JdeField("XCURAT", "XCURAT", JdeDataType.Numeric),
        new JdeField("XCURAB", "XCURAB", JdeDataType.Numeric),
        new JdeField("XCURRF", "XCURRF", JdeDataType.String, 30),
        new JdeField("XCUSER", "XCUSER", JdeDataType.String, 20),
        new JdeField("XCPID", "XCPID", JdeDataType.String, 20),
        new JdeField("XCJOBN", "XCJOBN", JdeDataType.String, 20),
        new JdeField("XCUPMJ", "XCUPMJ", JdeDataType.Numeric),
        new JdeField("XCTDAY", "XCTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40R21_0", "Primary Key on XCMCU, XCAN8, XCREQTYP, XCREQFRQ", new[] { "XCMCU", "XCAN8", "XCREQTYP", "XCREQFRQ" }, isUnique: true, isPrimaryKey: true)
    };
}
