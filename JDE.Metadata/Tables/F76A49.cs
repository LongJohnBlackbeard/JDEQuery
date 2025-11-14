using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A49 - .
/// </summary>
public class F76A49 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CRPYID.
        /// </summary>
        public const string CRPYID = "CRPYID";

        /// <summary>
        /// CREV01.
        /// </summary>
        public const string CREV01 = "CREV01";

        /// <summary>
        /// CRMATH01.
        /// </summary>
        public const string CRMATH01 = "CRMATH01";

        /// <summary>
        /// CRURC1.
        /// </summary>
        public const string CRURC1 = "CRURC1";

        /// <summary>
        /// CRURDT.
        /// </summary>
        public const string CRURDT = "CRURDT";

        /// <summary>
        /// CRURAT.
        /// </summary>
        public const string CRURAT = "CRURAT";

        /// <summary>
        /// CRURAB.
        /// </summary>
        public const string CRURAB = "CRURAB";

        /// <summary>
        /// CRURRF.
        /// </summary>
        public const string CRURRF = "CRURRF";

        /// <summary>
        /// CRUPMJ.
        /// </summary>
        public const string CRUPMJ = "CRUPMJ";

        /// <summary>
        /// CRUSER.
        /// </summary>
        public const string CRUSER = "CRUSER";

        /// <summary>
        /// CRJOBN.
        /// </summary>
        public const string CRJOBN = "CRJOBN";

        /// <summary>
        /// CRPID.
        /// </summary>
        public const string CRPID = "CRPID";

        /// <summary>
        /// CRUPMT.
        /// </summary>
        public const string CRUPMT = "CRUPMT";

        /// <summary>
        /// CREFTJ.
        /// </summary>
        public const string CREFTJ = "CREFTJ";
    }

    /// <inheritdoc />
    public override string TableName => "F76A49";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CRPYID", "CRPYID", JdeDataType.Numeric, null, true, true),
        new JdeField("CREV01", "CREV01", JdeDataType.String, 2, true, true),
        new JdeField("CRMATH01", "CRMATH01", JdeDataType.Numeric, null, true, true),
        new JdeField("CRURC1", "CRURC1", JdeDataType.String, 6),
        new JdeField("CRURDT", "CRURDT", JdeDataType.Numeric),
        new JdeField("CRURAT", "CRURAT", JdeDataType.Numeric),
        new JdeField("CRURAB", "CRURAB", JdeDataType.Numeric),
        new JdeField("CRURRF", "CRURRF", JdeDataType.String, 30),
        new JdeField("CRUPMJ", "CRUPMJ", JdeDataType.Numeric),
        new JdeField("CRUSER", "CRUSER", JdeDataType.String, 20),
        new JdeField("CRJOBN", "CRJOBN", JdeDataType.String, 20),
        new JdeField("CRPID", "CRPID", JdeDataType.String, 20),
        new JdeField("CRUPMT", "CRUPMT", JdeDataType.Numeric),
        new JdeField("CREFTJ", "CREFTJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A49_0", "Primary Key on CRPYID, CREV01, CRMATH01", new[] { "CRPYID", "CREV01", "CRMATH01" }, isUnique: true, isPrimaryKey: true)
    };
}
