using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43C60 - .
/// </summary>
public class F43C60 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CCCNTRTID.
        /// </summary>
        public const string CCCNTRTID = "CCCNTRTID";

        /// <summary>
        /// CCBLUID.
        /// </summary>
        public const string CCBLUID = "CCBLUID";

        /// <summary>
        /// CCCNTRTDID.
        /// </summary>
        public const string CCCNTRTDID = "CCCNTRTDID";

        /// <summary>
        /// CCUKID.
        /// </summary>
        public const string CCUKID = "CCUKID";

        /// <summary>
        /// CCCNTRTCLS.
        /// </summary>
        public const string CCCNTRTCLS = "CCCNTRTCLS";

        /// <summary>
        /// CCURCD.
        /// </summary>
        public const string CCURCD = "CCURCD";

        /// <summary>
        /// CCURDT.
        /// </summary>
        public const string CCURDT = "CCURDT";

        /// <summary>
        /// CCURAT.
        /// </summary>
        public const string CCURAT = "CCURAT";

        /// <summary>
        /// CCURAB.
        /// </summary>
        public const string CCURAB = "CCURAB";

        /// <summary>
        /// CCURRF.
        /// </summary>
        public const string CCURRF = "CCURRF";

        /// <summary>
        /// CCTORG.
        /// </summary>
        public const string CCTORG = "CCTORG";

        /// <summary>
        /// CCUSER.
        /// </summary>
        public const string CCUSER = "CCUSER";

        /// <summary>
        /// CCPID.
        /// </summary>
        public const string CCPID = "CCPID";

        /// <summary>
        /// CCJOBN.
        /// </summary>
        public const string CCJOBN = "CCJOBN";

        /// <summary>
        /// CCUUPMJ.
        /// </summary>
        public const string CCUUPMJ = "CCUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F43C60";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CCCNTRTID", "CCCNTRTID", JdeDataType.Numeric, null, true, true),
        new JdeField("CCBLUID", "CCBLUID", JdeDataType.Numeric, null, true, true),
        new JdeField("CCCNTRTDID", "CCCNTRTDID", JdeDataType.Numeric, null, true, true),
        new JdeField("CCUKID", "CCUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("CCCNTRTCLS", "CCCNTRTCLS", JdeDataType.String, 20),
        new JdeField("CCURCD", "CCURCD", JdeDataType.String, 4),
        new JdeField("CCURDT", "CCURDT", JdeDataType.Numeric),
        new JdeField("CCURAT", "CCURAT", JdeDataType.Numeric),
        new JdeField("CCURAB", "CCURAB", JdeDataType.Numeric),
        new JdeField("CCURRF", "CCURRF", JdeDataType.String, 30),
        new JdeField("CCTORG", "CCTORG", JdeDataType.String, 20),
        new JdeField("CCUSER", "CCUSER", JdeDataType.String, 20),
        new JdeField("CCPID", "CCPID", JdeDataType.String, 20),
        new JdeField("CCJOBN", "CCJOBN", JdeDataType.String, 20),
        new JdeField("CCUUPMJ", "CCUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43C60_0", "Primary Key on CCCNTRTID, CCBLUID, CCCNTRTDID, CCUKID", new[] { "CCCNTRTID", "CCBLUID", "CCCNTRTDID", "CCUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F43C60_2", "Index on CCCNTRTID, CCBLUID, CCCNTRTDID, CCCNTRTCLS", new[] { "CCCNTRTID", "CCBLUID", "CCCNTRTDID", "CCCNTRTCLS" })
    };
}
