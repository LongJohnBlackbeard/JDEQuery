using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08090 - .
/// </summary>
public class F08090 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JXRCOD.
        /// </summary>
        public const string JXRCOD = "JXRCOD";

        /// <summary>
        /// JXTYRC.
        /// </summary>
        public const string JXTYRC = "JXTYRC";

        /// <summary>
        /// JXDSPM.
        /// </summary>
        public const string JXDSPM = "JXDSPM";

        /// <summary>
        /// JXSEQ#.
        /// </summary>
        public const string JXSEQ_ = "JXSEQ#";

        /// <summary>
        /// JXDL01.
        /// </summary>
        public const string JXDL01 = "JXDL01";

        /// <summary>
        /// JXSY.
        /// </summary>
        public const string JXSY = "JXSY";

        /// <summary>
        /// JXRT.
        /// </summary>
        public const string JXRT = "JXRT";

        /// <summary>
        /// JXGDC1.
        /// </summary>
        public const string JXGDC1 = "JXGDC1";

        /// <summary>
        /// JXGDC2.
        /// </summary>
        public const string JXGDC2 = "JXGDC2";

        /// <summary>
        /// JXGDC3.
        /// </summary>
        public const string JXGDC3 = "JXGDC3";

        /// <summary>
        /// JXGDC4.
        /// </summary>
        public const string JXGDC4 = "JXGDC4";

        /// <summary>
        /// JXGDC5.
        /// </summary>
        public const string JXGDC5 = "JXGDC5";

        /// <summary>
        /// JXGDC6.
        /// </summary>
        public const string JXGDC6 = "JXGDC6";

        /// <summary>
        /// JXGDC7.
        /// </summary>
        public const string JXGDC7 = "JXGDC7";

        /// <summary>
        /// JXSY1.
        /// </summary>
        public const string JXSY1 = "JXSY1";

        /// <summary>
        /// JXRT1.
        /// </summary>
        public const string JXRT1 = "JXRT1";

        /// <summary>
        /// JXSY2.
        /// </summary>
        public const string JXSY2 = "JXSY2";

        /// <summary>
        /// JXRT2.
        /// </summary>
        public const string JXRT2 = "JXRT2";

        /// <summary>
        /// JXTYRG.
        /// </summary>
        public const string JXTYRG = "JXTYRG";

        /// <summary>
        /// JXDATD.
        /// </summary>
        public const string JXDATD = "JXDATD";

        /// <summary>
        /// JXAT1.
        /// </summary>
        public const string JXAT1 = "JXAT1";

        /// <summary>
        /// JXCLS.
        /// </summary>
        public const string JXCLS = "JXCLS";

        /// <summary>
        /// JXPGM.
        /// </summary>
        public const string JXPGM = "JXPGM";

        /// <summary>
        /// JXVERS.
        /// </summary>
        public const string JXVERS = "JXVERS";

        /// <summary>
        /// JXPGMG.
        /// </summary>
        public const string JXPGMG = "JXPGMG";

        /// <summary>
        /// JXFILE.
        /// </summary>
        public const string JXFILE = "JXFILE";

        /// <summary>
        /// JXDSS5.
        /// </summary>
        public const string JXDSS5 = "JXDSS5";

        /// <summary>
        /// JXCF.
        /// </summary>
        public const string JXCF = "JXCF";

        /// <summary>
        /// JXUSER.
        /// </summary>
        public const string JXUSER = "JXUSER";

        /// <summary>
        /// JXJOBN.
        /// </summary>
        public const string JXJOBN = "JXJOBN";

        /// <summary>
        /// JXUPMJ.
        /// </summary>
        public const string JXUPMJ = "JXUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F08090";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JXRCOD", "JXRCOD", JdeDataType.String, 2, true, true),
        new JdeField("JXTYRC", "JXTYRC", JdeDataType.String, 4, true, true),
        new JdeField("JXDSPM", "JXDSPM", JdeDataType.String, 2),
        new JdeField("JXSEQ#", "JXSEQ#", JdeDataType.Numeric),
        new JdeField("JXDL01", "JXDL01", JdeDataType.String, 60),
        new JdeField("JXSY", "JXSY", JdeDataType.String, 8),
        new JdeField("JXRT", "JXRT", JdeDataType.String, 4),
        new JdeField("JXGDC1", "JXGDC1", JdeDataType.String, 20),
        new JdeField("JXGDC2", "JXGDC2", JdeDataType.String, 20),
        new JdeField("JXGDC3", "JXGDC3", JdeDataType.String, 60),
        new JdeField("JXGDC4", "JXGDC4", JdeDataType.String, 60),
        new JdeField("JXGDC5", "JXGDC5", JdeDataType.String, 20),
        new JdeField("JXGDC6", "JXGDC6", JdeDataType.String, 20),
        new JdeField("JXGDC7", "JXGDC7", JdeDataType.String, 20),
        new JdeField("JXSY1", "JXSY1", JdeDataType.String, 8),
        new JdeField("JXRT1", "JXRT1", JdeDataType.String, 4),
        new JdeField("JXSY2", "JXSY2", JdeDataType.String, 8),
        new JdeField("JXRT2", "JXRT2", JdeDataType.String, 4),
        new JdeField("JXTYRG", "JXTYRG", JdeDataType.String, 6),
        new JdeField("JXDATD", "JXDATD", JdeDataType.String, 2),
        new JdeField("JXAT1", "JXAT1", JdeDataType.String, 6),
        new JdeField("JXCLS", "JXCLS", JdeDataType.String, 8),
        new JdeField("JXPGM", "JXPGM", JdeDataType.String, 20),
        new JdeField("JXVERS", "JXVERS", JdeDataType.String, 20),
        new JdeField("JXPGMG", "JXPGMG", JdeDataType.String, 20),
        new JdeField("JXFILE", "JXFILE", JdeDataType.String, 20),
        new JdeField("JXDSS5", "JXDSS5", JdeDataType.Numeric),
        new JdeField("JXCF", "JXCF", JdeDataType.String, 2),
        new JdeField("JXUSER", "JXUSER", JdeDataType.String, 20),
        new JdeField("JXJOBN", "JXJOBN", JdeDataType.String, 20),
        new JdeField("JXUPMJ", "JXUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08090_0", "Primary Key on JXRCOD, JXTYRC", new[] { "JXRCOD", "JXTYRC" }, isUnique: true, isPrimaryKey: true)
    };
}
