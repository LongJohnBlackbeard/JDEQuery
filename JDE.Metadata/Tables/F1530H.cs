using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1530H - .
/// </summary>
public class F1530H : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NGEPCL.
        /// </summary>
        public const string NGEPCL = "NGEPCL";

        /// <summary>
        /// NGDL01.
        /// </summary>
        public const string NGDL01 = "NGDL01";

        /// <summary>
        /// NGDS80.
        /// </summary>
        public const string NGDS80 = "NGDS80";

        /// <summary>
        /// NGEPCLCAT1.
        /// </summary>
        public const string NGEPCLCAT1 = "NGEPCLCAT1";

        /// <summary>
        /// NGEPCLCAT2.
        /// </summary>
        public const string NGEPCLCAT2 = "NGEPCLCAT2";

        /// <summary>
        /// NGEPCLCAT3.
        /// </summary>
        public const string NGEPCLCAT3 = "NGEPCLCAT3";

        /// <summary>
        /// NGEPCLCAT4.
        /// </summary>
        public const string NGEPCLCAT4 = "NGEPCLCAT4";

        /// <summary>
        /// NGEPCLCAT5.
        /// </summary>
        public const string NGEPCLCAT5 = "NGEPCLCAT5";

        /// <summary>
        /// NGURCD.
        /// </summary>
        public const string NGURCD = "NGURCD";

        /// <summary>
        /// NGURDT.
        /// </summary>
        public const string NGURDT = "NGURDT";

        /// <summary>
        /// NGURAT.
        /// </summary>
        public const string NGURAT = "NGURAT";

        /// <summary>
        /// NGURAB.
        /// </summary>
        public const string NGURAB = "NGURAB";

        /// <summary>
        /// NGURRF.
        /// </summary>
        public const string NGURRF = "NGURRF";

        /// <summary>
        /// NGUSER.
        /// </summary>
        public const string NGUSER = "NGUSER";

        /// <summary>
        /// NGPID.
        /// </summary>
        public const string NGPID = "NGPID";

        /// <summary>
        /// NGMKEY.
        /// </summary>
        public const string NGMKEY = "NGMKEY";

        /// <summary>
        /// NGUPMJ.
        /// </summary>
        public const string NGUPMJ = "NGUPMJ";

        /// <summary>
        /// NGUPMT.
        /// </summary>
        public const string NGUPMT = "NGUPMT";

        /// <summary>
        /// NGTORG.
        /// </summary>
        public const string NGTORG = "NGTORG";

        /// <summary>
        /// NGENTJ.
        /// </summary>
        public const string NGENTJ = "NGENTJ";
    }

    /// <inheritdoc />
    public override string TableName => "F1530H";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NGEPCL", "NGEPCL", JdeDataType.String, 8, true, true),
        new JdeField("NGDL01", "NGDL01", JdeDataType.String, 60),
        new JdeField("NGDS80", "NGDS80", JdeDataType.String, 160),
        new JdeField("NGEPCLCAT1", "NGEPCLCAT1", JdeDataType.String, 20),
        new JdeField("NGEPCLCAT2", "NGEPCLCAT2", JdeDataType.String, 20),
        new JdeField("NGEPCLCAT3", "NGEPCLCAT3", JdeDataType.String, 20),
        new JdeField("NGEPCLCAT4", "NGEPCLCAT4", JdeDataType.String, 20),
        new JdeField("NGEPCLCAT5", "NGEPCLCAT5", JdeDataType.String, 20),
        new JdeField("NGURCD", "NGURCD", JdeDataType.String, 4),
        new JdeField("NGURDT", "NGURDT", JdeDataType.Numeric),
        new JdeField("NGURAT", "NGURAT", JdeDataType.Numeric),
        new JdeField("NGURAB", "NGURAB", JdeDataType.Numeric),
        new JdeField("NGURRF", "NGURRF", JdeDataType.String, 30),
        new JdeField("NGUSER", "NGUSER", JdeDataType.String, 20),
        new JdeField("NGPID", "NGPID", JdeDataType.String, 20),
        new JdeField("NGMKEY", "NGMKEY", JdeDataType.String, 30),
        new JdeField("NGUPMJ", "NGUPMJ", JdeDataType.Numeric),
        new JdeField("NGUPMT", "NGUPMT", JdeDataType.Numeric),
        new JdeField("NGTORG", "NGTORG", JdeDataType.String, 20),
        new JdeField("NGENTJ", "NGENTJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1530H_0", "Primary Key on NGEPCL", new[] { "NGEPCL" }, isUnique: true, isPrimaryKey: true)
    };
}
