using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3462 - .
/// </summary>
public class F3462 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MBITM.
        /// </summary>
        public const string MBITM = "MBITM";

        /// <summary>
        /// MBLITM.
        /// </summary>
        public const string MBLITM = "MBLITM";

        /// <summary>
        /// MBAITM.
        /// </summary>
        public const string MBAITM = "MBAITM";

        /// <summary>
        /// MBMCU.
        /// </summary>
        public const string MBMCU = "MBMCU";

        /// <summary>
        /// MBCO.
        /// </summary>
        public const string MBCO = "MBCO";

        /// <summary>
        /// MBUORG.
        /// </summary>
        public const string MBUORG = "MBUORG";

        /// <summary>
        /// MBPDDJ.
        /// </summary>
        public const string MBPDDJ = "MBPDDJ";

        /// <summary>
        /// MBUPMJ.
        /// </summary>
        public const string MBUPMJ = "MBUPMJ";

        /// <summary>
        /// MBUSER.
        /// </summary>
        public const string MBUSER = "MBUSER";

        /// <summary>
        /// MBJOBN.
        /// </summary>
        public const string MBJOBN = "MBJOBN";

        /// <summary>
        /// MBPID.
        /// </summary>
        public const string MBPID = "MBPID";

        /// <summary>
        /// MBTDAY.
        /// </summary>
        public const string MBTDAY = "MBTDAY";

        /// <summary>
        /// MBUKID.
        /// </summary>
        public const string MBUKID = "MBUKID";

        /// <summary>
        /// MBSHAN.
        /// </summary>
        public const string MBSHAN = "MBSHAN";
    }

    /// <inheritdoc />
    public override string TableName => "F3462";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MBITM", "MBITM", JdeDataType.Numeric),
        new JdeField("MBLITM", "MBLITM", JdeDataType.String, 50),
        new JdeField("MBAITM", "MBAITM", JdeDataType.String, 50),
        new JdeField("MBMCU", "MBMCU", JdeDataType.String, 24),
        new JdeField("MBCO", "MBCO", JdeDataType.String, 10),
        new JdeField("MBUORG", "MBUORG", JdeDataType.Numeric),
        new JdeField("MBPDDJ", "MBPDDJ", JdeDataType.Numeric),
        new JdeField("MBUPMJ", "MBUPMJ", JdeDataType.Numeric),
        new JdeField("MBUSER", "MBUSER", JdeDataType.String, 20),
        new JdeField("MBJOBN", "MBJOBN", JdeDataType.String, 20),
        new JdeField("MBPID", "MBPID", JdeDataType.String, 20),
        new JdeField("MBTDAY", "MBTDAY", JdeDataType.Numeric),
        new JdeField("MBUKID", "MBUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("MBSHAN", "MBSHAN", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3462_0", "Primary Key on MBUKID", new[] { "MBUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F3462_1", "Unique Index on MBITM, MBMCU, MBPDDJ", new[] { "MBITM", "MBMCU", "MBPDDJ" }, isUnique: true),
        new JdeIndex("F3462_3", "Index on MBITM, MBPDDJ", new[] { "MBITM", "MBPDDJ" }),
        new JdeIndex("F3462_5", "Unique Index on MBITM, MBMCU, MBSHAN, MBPDDJ", new[] { "MBITM", "MBMCU", "MBSHAN", "MBPDDJ" }, isUnique: true)
    };
}
