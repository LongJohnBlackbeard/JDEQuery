using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1754 - .
/// </summary>
public class F1754 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ZBITYPE.
        /// </summary>
        public const string ZBITYPE = "ZBITYPE";

        /// <summary>
        /// ZBPRODF.
        /// </summary>
        public const string ZBPRODF = "ZBPRODF";

        /// <summary>
        /// ZBPRODM.
        /// </summary>
        public const string ZBPRODM = "ZBPRODM";

        /// <summary>
        /// ZBENV.
        /// </summary>
        public const string ZBENV = "ZBENV";

        /// <summary>
        /// ZBAN8C.
        /// </summary>
        public const string ZBAN8C = "ZBAN8C";

        /// <summary>
        /// ZBAN86.
        /// </summary>
        public const string ZBAN86 = "ZBAN86";

        /// <summary>
        /// ZBREGION.
        /// </summary>
        public const string ZBREGION = "ZBREGION";

        /// <summary>
        /// ZBLNGP.
        /// </summary>
        public const string ZBLNGP = "ZBLNGP";

        /// <summary>
        /// ZBTYPS.
        /// </summary>
        public const string ZBTYPS = "ZBTYPS";

        /// <summary>
        /// ZBCALLQ.
        /// </summary>
        public const string ZBCALLQ = "ZBCALLQ";

        /// <summary>
        /// ZBAN8.
        /// </summary>
        public const string ZBAN8 = "ZBAN8";

        /// <summary>
        /// ZBUSER.
        /// </summary>
        public const string ZBUSER = "ZBUSER";

        /// <summary>
        /// ZBUPMJ.
        /// </summary>
        public const string ZBUPMJ = "ZBUPMJ";

        /// <summary>
        /// ZBUPMT.
        /// </summary>
        public const string ZBUPMT = "ZBUPMT";

        /// <summary>
        /// ZBJOBN.
        /// </summary>
        public const string ZBJOBN = "ZBJOBN";

        /// <summary>
        /// ZBPID.
        /// </summary>
        public const string ZBPID = "ZBPID";
    }

    /// <inheritdoc />
    public override string TableName => "F1754";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZBITYPE", "ZBITYPE", JdeDataType.String, 2, true, true),
        new JdeField("ZBPRODF", "ZBPRODF", JdeDataType.String, 16, true, true),
        new JdeField("ZBPRODM", "ZBPRODM", JdeDataType.String, 16, true, true),
        new JdeField("ZBENV", "ZBENV", JdeDataType.String, 20, true, true),
        new JdeField("ZBAN8C", "ZBAN8C", JdeDataType.Numeric, null, true, true),
        new JdeField("ZBAN86", "ZBAN86", JdeDataType.Numeric, null, true, true),
        new JdeField("ZBREGION", "ZBREGION", JdeDataType.String, 6, true, true),
        new JdeField("ZBLNGP", "ZBLNGP", JdeDataType.String, 4, true, true),
        new JdeField("ZBTYPS", "ZBTYPS", JdeDataType.String, 2, true, true),
        new JdeField("ZBCALLQ", "ZBCALLQ", JdeDataType.Numeric),
        new JdeField("ZBAN8", "ZBAN8", JdeDataType.Numeric),
        new JdeField("ZBUSER", "ZBUSER", JdeDataType.String, 20),
        new JdeField("ZBUPMJ", "ZBUPMJ", JdeDataType.Numeric),
        new JdeField("ZBUPMT", "ZBUPMT", JdeDataType.Numeric),
        new JdeField("ZBJOBN", "ZBJOBN", JdeDataType.String, 20),
        new JdeField("ZBPID", "ZBPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1754_0", "Primary Key on ZBITYPE, ZBPRODF, ZBPRODM, ZBENV, ZBAN8C, ZBAN86, ZBLNGP, ZBREGION, ZBTYPS", new[] { "ZBITYPE", "ZBPRODF", "ZBPRODM", "ZBENV", "ZBAN8C", "ZBAN86", "ZBLNGP", "ZBREGION", "ZBTYPS" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F1754_2", "Index on ZBCALLQ", new[] { "ZBCALLQ" })
    };
}
