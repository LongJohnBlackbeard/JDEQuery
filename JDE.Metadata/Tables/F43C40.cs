using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43C40 - .
/// </summary>
public class F43C40 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ACCNTRTID.
        /// </summary>
        public const string ACCNTRTID = "ACCNTRTID";

        /// <summary>
        /// ACBLUID.
        /// </summary>
        public const string ACBLUID = "ACBLUID";

        /// <summary>
        /// ACCNTRTDID.
        /// </summary>
        public const string ACCNTRTDID = "ACCNTRTDID";

        /// <summary>
        /// ACADUKID.
        /// </summary>
        public const string ACADUKID = "ACADUKID";

        /// <summary>
        /// ACASPD.
        /// </summary>
        public const string ACASPD = "ACASPD";

        /// <summary>
        /// ACURCD.
        /// </summary>
        public const string ACURCD = "ACURCD";

        /// <summary>
        /// ACURDT.
        /// </summary>
        public const string ACURDT = "ACURDT";

        /// <summary>
        /// ACURAT.
        /// </summary>
        public const string ACURAT = "ACURAT";

        /// <summary>
        /// ACURAB.
        /// </summary>
        public const string ACURAB = "ACURAB";

        /// <summary>
        /// ACURRF.
        /// </summary>
        public const string ACURRF = "ACURRF";

        /// <summary>
        /// ACTORG.
        /// </summary>
        public const string ACTORG = "ACTORG";

        /// <summary>
        /// ACUSER.
        /// </summary>
        public const string ACUSER = "ACUSER";

        /// <summary>
        /// ACPID.
        /// </summary>
        public const string ACPID = "ACPID";

        /// <summary>
        /// ACJOBN.
        /// </summary>
        public const string ACJOBN = "ACJOBN";

        /// <summary>
        /// ACUUPMJ.
        /// </summary>
        public const string ACUUPMJ = "ACUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F43C40";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ACCNTRTID", "ACCNTRTID", JdeDataType.Numeric, null, true, true),
        new JdeField("ACBLUID", "ACBLUID", JdeDataType.Numeric, null, true, true),
        new JdeField("ACCNTRTDID", "ACCNTRTDID", JdeDataType.Numeric, null, true, true),
        new JdeField("ACADUKID", "ACADUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("ACASPD", "ACASPD", JdeDataType.String, 2),
        new JdeField("ACURCD", "ACURCD", JdeDataType.String, 4),
        new JdeField("ACURDT", "ACURDT", JdeDataType.Numeric),
        new JdeField("ACURAT", "ACURAT", JdeDataType.Numeric),
        new JdeField("ACURAB", "ACURAB", JdeDataType.Numeric),
        new JdeField("ACURRF", "ACURRF", JdeDataType.String, 30),
        new JdeField("ACTORG", "ACTORG", JdeDataType.String, 20),
        new JdeField("ACUSER", "ACUSER", JdeDataType.String, 20),
        new JdeField("ACPID", "ACPID", JdeDataType.String, 20),
        new JdeField("ACJOBN", "ACJOBN", JdeDataType.String, 20),
        new JdeField("ACUUPMJ", "ACUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43C40_0", "Primary Key on ACCNTRTID, ACBLUID, ACCNTRTDID, ACADUKID", new[] { "ACCNTRTID", "ACBLUID", "ACCNTRTDID", "ACADUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F43C40_2", "Index on ACADUKID, ACCNTRTID, ACBLUID, ACCNTRTDID", new[] { "ACADUKID", "ACCNTRTID", "ACBLUID", "ACCNTRTDID" }),
        new JdeIndex("F43C40_3", "Index on ACCNTRTID, ACBLUID, ACCNTRTDID, ACASPD, ACADUKID", new[] { "ACCNTRTID", "ACBLUID", "ACCNTRTDID", "ACASPD", "ACADUKID" })
    };
}
