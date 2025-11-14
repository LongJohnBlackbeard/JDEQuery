using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74Z0020 - .
/// </summary>
public class F74Z0020 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CZCO.
        /// </summary>
        public const string CZCO = "CZCO";

        /// <summary>
        /// CZTXA1.
        /// </summary>
        public const string CZTXA1 = "CZTXA1";

        /// <summary>
        /// CZ74ZSNT.
        /// </summary>
        public const string CZ74ZSNT = "CZ74ZSNT";

        /// <summary>
        /// CZEFTJ.
        /// </summary>
        public const string CZEFTJ = "CZEFTJ";

        /// <summary>
        /// CZEFDJ.
        /// </summary>
        public const string CZEFDJ = "CZEFDJ";

        /// <summary>
        /// CZACTIVEYN.
        /// </summary>
        public const string CZACTIVEYN = "CZACTIVEYN";

        /// <summary>
        /// CZUPMJ.
        /// </summary>
        public const string CZUPMJ = "CZUPMJ";

        /// <summary>
        /// CZUPMT.
        /// </summary>
        public const string CZUPMT = "CZUPMT";

        /// <summary>
        /// CZPID.
        /// </summary>
        public const string CZPID = "CZPID";

        /// <summary>
        /// CZUSER.
        /// </summary>
        public const string CZUSER = "CZUSER";

        /// <summary>
        /// CZJOBN.
        /// </summary>
        public const string CZJOBN = "CZJOBN";

        /// <summary>
        /// CZDATF01.
        /// </summary>
        public const string CZDATF01 = "CZDATF01";

        /// <summary>
        /// CZDEPFUT2.
        /// </summary>
        public const string CZDEPFUT2 = "CZDEPFUT2";

        /// <summary>
        /// CZACTFU1.
        /// </summary>
        public const string CZACTFU1 = "CZACTFU1";
    }

    /// <inheritdoc />
    public override string TableName => "F74Z0020";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CZCO", "CZCO", JdeDataType.String, 10, true, true),
        new JdeField("CZTXA1", "CZTXA1", JdeDataType.String, 20, true, true),
        new JdeField("CZ74ZSNT", "CZ74ZSNT", JdeDataType.String, 12),
        new JdeField("CZEFTJ", "CZEFTJ", JdeDataType.Numeric),
        new JdeField("CZEFDJ", "CZEFDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("CZACTIVEYN", "CZACTIVEYN", JdeDataType.String, 2),
        new JdeField("CZUPMJ", "CZUPMJ", JdeDataType.Numeric),
        new JdeField("CZUPMT", "CZUPMT", JdeDataType.Numeric),
        new JdeField("CZPID", "CZPID", JdeDataType.String, 20),
        new JdeField("CZUSER", "CZUSER", JdeDataType.String, 20),
        new JdeField("CZJOBN", "CZJOBN", JdeDataType.String, 20),
        new JdeField("CZDATF01", "CZDATF01", JdeDataType.Numeric),
        new JdeField("CZDEPFUT2", "CZDEPFUT2", JdeDataType.String, 60),
        new JdeField("CZACTFU1", "CZACTFU1", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74Z0020_0", "Primary Key on CZCO, CZTXA1, CZEFDJ", new[] { "CZCO", "CZTXA1", "CZEFDJ" }, isUnique: true, isPrimaryKey: true)
    };
}
