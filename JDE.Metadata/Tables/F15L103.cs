using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15L103 - .
/// </summary>
public class F15L103 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SHMCU.
        /// </summary>
        public const string SHMCU = "SHMCU";

        /// <summary>
        /// SHRVNB.
        /// </summary>
        public const string SHRVNB = "SHRVNB";

        /// <summary>
        /// SHSOID.
        /// </summary>
        public const string SHSOID = "SHSOID";

        /// <summary>
        /// SHDESC.
        /// </summary>
        public const string SHDESC = "SHDESC";

        /// <summary>
        /// SHSGPN.
        /// </summary>
        public const string SHSGPN = "SHSGPN";

        /// <summary>
        /// SHSGOV.
        /// </summary>
        public const string SHSGOV = "SHSGOV";

        /// <summary>
        /// SHMBCD.
        /// </summary>
        public const string SHMBCD = "SHMBCD";

        /// <summary>
        /// SHCMTB.
        /// </summary>
        public const string SHCMTB = "SHCMTB";

        /// <summary>
        /// SHCMTE.
        /// </summary>
        public const string SHCMTE = "SHCMTE";

        /// <summary>
        /// SHCMPM.
        /// </summary>
        public const string SHCMPM = "SHCMPM";

        /// <summary>
        /// SHRL01.
        /// </summary>
        public const string SHRL01 = "SHRL01";

        /// <summary>
        /// SHRL02.
        /// </summary>
        public const string SHRL02 = "SHRL02";

        /// <summary>
        /// SHRL03.
        /// </summary>
        public const string SHRL03 = "SHRL03";

        /// <summary>
        /// SHRL04.
        /// </summary>
        public const string SHRL04 = "SHRL04";

        /// <summary>
        /// SHRL05.
        /// </summary>
        public const string SHRL05 = "SHRL05";

        /// <summary>
        /// SHURCD.
        /// </summary>
        public const string SHURCD = "SHURCD";

        /// <summary>
        /// SHURDT.
        /// </summary>
        public const string SHURDT = "SHURDT";

        /// <summary>
        /// SHURAT.
        /// </summary>
        public const string SHURAT = "SHURAT";

        /// <summary>
        /// SHURAB.
        /// </summary>
        public const string SHURAB = "SHURAB";

        /// <summary>
        /// SHURRF.
        /// </summary>
        public const string SHURRF = "SHURRF";

        /// <summary>
        /// SHUSER.
        /// </summary>
        public const string SHUSER = "SHUSER";

        /// <summary>
        /// SHPID.
        /// </summary>
        public const string SHPID = "SHPID";

        /// <summary>
        /// SHUPMJ.
        /// </summary>
        public const string SHUPMJ = "SHUPMJ";

        /// <summary>
        /// SHUPMT.
        /// </summary>
        public const string SHUPMT = "SHUPMT";

        /// <summary>
        /// SHJOBN.
        /// </summary>
        public const string SHJOBN = "SHJOBN";

        /// <summary>
        /// SHTORG.
        /// </summary>
        public const string SHTORG = "SHTORG";

        /// <summary>
        /// SHENTJ.
        /// </summary>
        public const string SHENTJ = "SHENTJ";
    }

    /// <inheritdoc />
    public override string TableName => "F15L103";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SHMCU", "SHMCU", JdeDataType.String, 24, true, true),
        new JdeField("SHRVNB", "SHRVNB", JdeDataType.Numeric, null, true, true),
        new JdeField("SHSOID", "SHSOID", JdeDataType.String, 20, true, true),
        new JdeField("SHDESC", "SHDESC", JdeDataType.String, 60),
        new JdeField("SHSGPN", "SHSGPN", JdeDataType.String, 20),
        new JdeField("SHSGOV", "SHSGOV", JdeDataType.String, 2),
        new JdeField("SHMBCD", "SHMBCD", JdeDataType.String, 8),
        new JdeField("SHCMTB", "SHCMTB", JdeDataType.Numeric),
        new JdeField("SHCMTE", "SHCMTE", JdeDataType.Numeric),
        new JdeField("SHCMPM", "SHCMPM", JdeDataType.String, 2),
        new JdeField("SHRL01", "SHRL01", JdeDataType.String, 6),
        new JdeField("SHRL02", "SHRL02", JdeDataType.String, 6),
        new JdeField("SHRL03", "SHRL03", JdeDataType.String, 6),
        new JdeField("SHRL04", "SHRL04", JdeDataType.String, 6),
        new JdeField("SHRL05", "SHRL05", JdeDataType.String, 6),
        new JdeField("SHURCD", "SHURCD", JdeDataType.String, 4),
        new JdeField("SHURDT", "SHURDT", JdeDataType.Numeric),
        new JdeField("SHURAT", "SHURAT", JdeDataType.Numeric),
        new JdeField("SHURAB", "SHURAB", JdeDataType.Numeric),
        new JdeField("SHURRF", "SHURRF", JdeDataType.String, 30),
        new JdeField("SHUSER", "SHUSER", JdeDataType.String, 20),
        new JdeField("SHPID", "SHPID", JdeDataType.String, 20),
        new JdeField("SHUPMJ", "SHUPMJ", JdeDataType.Numeric),
        new JdeField("SHUPMT", "SHUPMT", JdeDataType.Numeric),
        new JdeField("SHJOBN", "SHJOBN", JdeDataType.String, 20),
        new JdeField("SHTORG", "SHTORG", JdeDataType.String, 20),
        new JdeField("SHENTJ", "SHENTJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15L103_0", "Primary Key on SHMCU, SHRVNB, SHSOID", new[] { "SHMCU", "SHRVNB", "SHSOID" }, isUnique: true, isPrimaryKey: true)
    };
}
