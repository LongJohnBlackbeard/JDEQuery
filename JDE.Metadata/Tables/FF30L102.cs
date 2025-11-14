using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF30L102 - .
/// </summary>
public class FF30L102 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FDMMFID.
        /// </summary>
        public const string FDMMFID = "FDMMFID";

        /// <summary>
        /// FDDFITM.
        /// </summary>
        public const string FDDFITM = "FDDFITM";

        /// <summary>
        /// FDDFMCU.
        /// </summary>
        public const string FDDFMCU = "FDDFMCU";

        /// <summary>
        /// FDFSCID.
        /// </summary>
        public const string FDFSCID = "FDFSCID";

        /// <summary>
        /// FDDSC1.
        /// </summary>
        public const string FDDSC1 = "FDDSC1";

        /// <summary>
        /// FDURCD.
        /// </summary>
        public const string FDURCD = "FDURCD";

        /// <summary>
        /// FDURDT.
        /// </summary>
        public const string FDURDT = "FDURDT";

        /// <summary>
        /// FDURAT.
        /// </summary>
        public const string FDURAT = "FDURAT";

        /// <summary>
        /// FDURAB.
        /// </summary>
        public const string FDURAB = "FDURAB";

        /// <summary>
        /// FDURRF.
        /// </summary>
        public const string FDURRF = "FDURRF";

        /// <summary>
        /// FDUSER.
        /// </summary>
        public const string FDUSER = "FDUSER";

        /// <summary>
        /// FDPID.
        /// </summary>
        public const string FDPID = "FDPID";

        /// <summary>
        /// FDMKEY.
        /// </summary>
        public const string FDMKEY = "FDMKEY";

        /// <summary>
        /// FDUUPMJ.
        /// </summary>
        public const string FDUUPMJ = "FDUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "FF30L102";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FDMMFID", "FDMMFID", JdeDataType.Numeric, null, true, true),
        new JdeField("FDDFITM", "FDDFITM", JdeDataType.Numeric, null, true, true),
        new JdeField("FDDFMCU", "FDDFMCU", JdeDataType.String, 24, true, true),
        new JdeField("FDFSCID", "FDFSCID", JdeDataType.Numeric, null, true, true),
        new JdeField("FDDSC1", "FDDSC1", JdeDataType.String, 60),
        new JdeField("FDURCD", "FDURCD", JdeDataType.String, 4),
        new JdeField("FDURDT", "FDURDT", JdeDataType.Numeric),
        new JdeField("FDURAT", "FDURAT", JdeDataType.Numeric),
        new JdeField("FDURAB", "FDURAB", JdeDataType.Numeric),
        new JdeField("FDURRF", "FDURRF", JdeDataType.String, 30),
        new JdeField("FDUSER", "FDUSER", JdeDataType.String, 20),
        new JdeField("FDPID", "FDPID", JdeDataType.String, 20),
        new JdeField("FDMKEY", "FDMKEY", JdeDataType.String, 30),
        new JdeField("FDUUPMJ", "FDUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF30L102_0", "Primary Key on FDMMFID, FDDFITM, FDDFMCU, FDFSCID", new[] { "FDMMFID", "FDDFITM", "FDDFMCU", "FDFSCID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF30L102_2", "Index on FDFSCID", new[] { "FDFSCID" })
    };
}
