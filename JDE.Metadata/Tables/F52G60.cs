using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F52G60 - .
/// </summary>
public class F52G60 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BWREFID.
        /// </summary>
        public const string BWREFID = "BWREFID";

        /// <summary>
        /// BWLT.
        /// </summary>
        public const string BWLT = "BWLT";

        /// <summary>
        /// BWAID.
        /// </summary>
        public const string BWAID = "BWAID";

        /// <summary>
        /// BWSEGMID.
        /// </summary>
        public const string BWSEGMID = "BWSEGMID";

        /// <summary>
        /// BWBUCA.
        /// </summary>
        public const string BWBUCA = "BWBUCA";

        /// <summary>
        /// BWSEQ.
        /// </summary>
        public const string BWSEQ = "BWSEQ";

        /// <summary>
        /// BWPOOLID.
        /// </summary>
        public const string BWPOOLID = "BWPOOLID";

        /// <summary>
        /// BWBEOR.
        /// </summary>
        public const string BWBEOR = "BWBEOR";

        /// <summary>
        /// BWPGC.
        /// </summary>
        public const string BWPGC = "BWPGC";

        /// <summary>
        /// BWBOBC.
        /// </summary>
        public const string BWBOBC = "BWBOBC";

        /// <summary>
        /// BWBOBS.
        /// </summary>
        public const string BWBOBS = "BWBOBS";

        /// <summary>
        /// BWBSOU.
        /// </summary>
        public const string BWBSOU = "BWBSOU";

        /// <summary>
        /// BWEPGC.
        /// </summary>
        public const string BWEPGC = "BWEPGC";

        /// <summary>
        /// BWJPGC.
        /// </summary>
        public const string BWJPGC = "BWJPGC";

        /// <summary>
        /// BWILEL.
        /// </summary>
        public const string BWILEL = "BWILEL";

        /// <summary>
        /// BWBOPI.
        /// </summary>
        public const string BWBOPI = "BWBOPI";

        /// <summary>
        /// BWAA.
        /// </summary>
        public const string BWAA = "BWAA";

        /// <summary>
        /// BWAA2.
        /// </summary>
        public const string BWAA2 = "BWAA2";

        /// <summary>
        /// BWARPER.
        /// </summary>
        public const string BWARPER = "BWARPER";

        /// <summary>
        /// BWFRPE.
        /// </summary>
        public const string BWFRPE = "BWFRPE";

        /// <summary>
        /// BWFRCY.
        /// </summary>
        public const string BWFRCY = "BWFRCY";

        /// <summary>
        /// BWTHPE.
        /// </summary>
        public const string BWTHPE = "BWTHPE";

        /// <summary>
        /// BWTHCY.
        /// </summary>
        public const string BWTHCY = "BWTHCY";

        /// <summary>
        /// BWUNAL.
        /// </summary>
        public const string BWUNAL = "BWUNAL";

        /// <summary>
        /// BWCLNU.
        /// </summary>
        public const string BWCLNU = "BWCLNU";

        /// <summary>
        /// BWPCTN.
        /// </summary>
        public const string BWPCTN = "BWPCTN";

        /// <summary>
        /// BWDOCO.
        /// </summary>
        public const string BWDOCO = "BWDOCO";

        /// <summary>
        /// BWTRRN.
        /// </summary>
        public const string BWTRRN = "BWTRRN";

        /// <summary>
        /// BWMCU.
        /// </summary>
        public const string BWMCU = "BWMCU";

        /// <summary>
        /// BWOBJ.
        /// </summary>
        public const string BWOBJ = "BWOBJ";

        /// <summary>
        /// BWSUB.
        /// </summary>
        public const string BWSUB = "BWSUB";

        /// <summary>
        /// BWCRCX.
        /// </summary>
        public const string BWCRCX = "BWCRCX";

        /// <summary>
        /// BWPID.
        /// </summary>
        public const string BWPID = "BWPID";

        /// <summary>
        /// BWJOBN.
        /// </summary>
        public const string BWJOBN = "BWJOBN";

        /// <summary>
        /// BWUSER.
        /// </summary>
        public const string BWUSER = "BWUSER";

        /// <summary>
        /// BWUPMJ.
        /// </summary>
        public const string BWUPMJ = "BWUPMJ";

        /// <summary>
        /// BWUPMT.
        /// </summary>
        public const string BWUPMT = "BWUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F52G60";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BWREFID", "BWREFID", JdeDataType.String, 20, true, true),
        new JdeField("BWLT", "BWLT", JdeDataType.String, 4),
        new JdeField("BWAID", "BWAID", JdeDataType.String, 16),
        new JdeField("BWSEGMID", "BWSEGMID", JdeDataType.String, 6, true, true),
        new JdeField("BWBUCA", "BWBUCA", JdeDataType.String, 10),
        new JdeField("BWSEQ", "BWSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("BWPOOLID", "BWPOOLID", JdeDataType.String, 8, true, true),
        new JdeField("BWBEOR", "BWBEOR", JdeDataType.String, 2),
        new JdeField("BWPGC", "BWPGC", JdeDataType.String, 6),
        new JdeField("BWBOBC", "BWBOBC", JdeDataType.String, 10),
        new JdeField("BWBOBS", "BWBOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("BWBSOU", "BWBSOU", JdeDataType.String, 2),
        new JdeField("BWEPGC", "BWEPGC", JdeDataType.String, 6),
        new JdeField("BWJPGC", "BWJPGC", JdeDataType.String, 6),
        new JdeField("BWILEL", "BWILEL", JdeDataType.String, 2),
        new JdeField("BWBOPI", "BWBOPI", JdeDataType.String, 8),
        new JdeField("BWAA", "BWAA", JdeDataType.Numeric),
        new JdeField("BWAA2", "BWAA2", JdeDataType.Numeric),
        new JdeField("BWARPER", "BWARPER", JdeDataType.Numeric),
        new JdeField("BWFRPE", "BWFRPE", JdeDataType.Numeric),
        new JdeField("BWFRCY", "BWFRCY", JdeDataType.Numeric),
        new JdeField("BWTHPE", "BWTHPE", JdeDataType.Numeric),
        new JdeField("BWTHCY", "BWTHCY", JdeDataType.Numeric),
        new JdeField("BWUNAL", "BWUNAL", JdeDataType.String, 2),
        new JdeField("BWCLNU", "BWCLNU", JdeDataType.Numeric),
        new JdeField("BWPCTN", "BWPCTN", JdeDataType.Numeric),
        new JdeField("BWDOCO", "BWDOCO", JdeDataType.Numeric),
        new JdeField("BWTRRN", "BWTRRN", JdeDataType.Numeric, null, true, true),
        new JdeField("BWMCU", "BWMCU", JdeDataType.String, 24),
        new JdeField("BWOBJ", "BWOBJ", JdeDataType.String, 12),
        new JdeField("BWSUB", "BWSUB", JdeDataType.String, 16),
        new JdeField("BWCRCX", "BWCRCX", JdeDataType.String, 6),
        new JdeField("BWPID", "BWPID", JdeDataType.String, 20),
        new JdeField("BWJOBN", "BWJOBN", JdeDataType.String, 20),
        new JdeField("BWUSER", "BWUSER", JdeDataType.String, 20),
        new JdeField("BWUPMJ", "BWUPMJ", JdeDataType.Numeric),
        new JdeField("BWUPMT", "BWUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F52G60_0", "Primary Key on BWREFID, BWTRRN, BWSEQ, BWBOBS, BWSEGMID, BWPOOLID", new[] { "BWREFID", "BWTRRN", "BWSEQ", "BWBOBS", "BWSEGMID", "BWPOOLID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F52G60_2", "Index on BWREFID, BWSEGMID, BWSEQ, BWPOOLID, BWBEOR", new[] { "BWREFID", "BWSEGMID", "BWSEQ", "BWPOOLID", "BWBEOR" }),
        new JdeIndex("F52G60_3", "Index on BWREFID, BWSEGMID, BWBOBS, BWBOPI, BWTRRN, BWBEOR", new[] { "BWREFID", "BWSEGMID", "BWBOBS", "BWBOPI", "BWTRRN", "BWBEOR" }),
        new JdeIndex("F52G60_4", "Index on BWREFID, BWSEQ, BWPOOLID, BWTRRN, BWBOBS, BWBEOR", new[] { "BWREFID", "BWSEQ", "BWPOOLID", "BWTRRN", "BWBOBS", "BWBEOR" }),
        new JdeIndex("F52G60_5", "Index on BWREFID", new[] { "BWREFID" })
    };
}
