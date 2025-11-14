using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40G022 - .
/// </summary>
public class F40G022 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BSBLUID.
        /// </summary>
        public const string BSBLUID = "BSBLUID";

        /// <summary>
        /// BSSITEM.
        /// </summary>
        public const string BSSITEM = "BSSITEM";

        /// <summary>
        /// BSURCD.
        /// </summary>
        public const string BSURCD = "BSURCD";

        /// <summary>
        /// BSURDT.
        /// </summary>
        public const string BSURDT = "BSURDT";

        /// <summary>
        /// BSURRF.
        /// </summary>
        public const string BSURRF = "BSURRF";

        /// <summary>
        /// BSURAT.
        /// </summary>
        public const string BSURAT = "BSURAT";

        /// <summary>
        /// BSURAB.
        /// </summary>
        public const string BSURAB = "BSURAB";

        /// <summary>
        /// BSPID.
        /// </summary>
        public const string BSPID = "BSPID";

        /// <summary>
        /// BSTORG.
        /// </summary>
        public const string BSTORG = "BSTORG";

        /// <summary>
        /// BSUSER.
        /// </summary>
        public const string BSUSER = "BSUSER";

        /// <summary>
        /// BSJOBN.
        /// </summary>
        public const string BSJOBN = "BSJOBN";

        /// <summary>
        /// BSUUPMJ.
        /// </summary>
        public const string BSUUPMJ = "BSUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F40G022";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BSBLUID", "BSBLUID", JdeDataType.Numeric, null, true, true),
        new JdeField("BSSITEM", "BSSITEM", JdeDataType.String, 24, true, true),
        new JdeField("BSURCD", "BSURCD", JdeDataType.String, 4),
        new JdeField("BSURDT", "BSURDT", JdeDataType.Numeric),
        new JdeField("BSURRF", "BSURRF", JdeDataType.String, 30),
        new JdeField("BSURAT", "BSURAT", JdeDataType.Numeric),
        new JdeField("BSURAB", "BSURAB", JdeDataType.Numeric),
        new JdeField("BSPID", "BSPID", JdeDataType.String, 20),
        new JdeField("BSTORG", "BSTORG", JdeDataType.String, 20),
        new JdeField("BSUSER", "BSUSER", JdeDataType.String, 20),
        new JdeField("BSJOBN", "BSJOBN", JdeDataType.String, 20),
        new JdeField("BSUUPMJ", "BSUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40G022_0", "Primary Key on BSBLUID, BSSITEM", new[] { "BSBLUID", "BSSITEM" }, isUnique: true, isPrimaryKey: true)
    };
}
