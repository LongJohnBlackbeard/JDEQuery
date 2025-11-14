using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09610 - .
/// </summary>
public class F09610 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SGBSTN.
        /// </summary>
        public const string SGBSTN = "SGBSTN";

        /// <summary>
        /// SGSTMD.
        /// </summary>
        public const string SGSTMD = "SGSTMD";

        /// <summary>
        /// SGBAN.
        /// </summary>
        public const string SGBAN = "SGBAN";

        /// <summary>
        /// SGBSSEQ.
        /// </summary>
        public const string SGBSSEQ = "SGBSSEQ";

        /// <summary>
        /// SGBKSTID.
        /// </summary>
        public const string SGBKSTID = "SGBKSTID";

        /// <summary>
        /// SGMESST.
        /// </summary>
        public const string SGMESST = "SGMESST";

        /// <summary>
        /// SGDESC04.
        /// </summary>
        public const string SGDESC04 = "SGDESC04";

        /// <summary>
        /// SGOBDBCR.
        /// </summary>
        public const string SGOBDBCR = "SGOBDBCR";

        /// <summary>
        /// SGOLVDT.
        /// </summary>
        public const string SGOLVDT = "SGOLVDT";

        /// <summary>
        /// SGOCRCD.
        /// </summary>
        public const string SGOCRCD = "SGOCRCD";

        /// <summary>
        /// SGTCRCD.
        /// </summary>
        public const string SGTCRCD = "SGTCRCD";

        /// <summary>
        /// SGOPBAA.
        /// </summary>
        public const string SGOPBAA = "SGOPBAA";

        /// <summary>
        /// SGCBDBCR.
        /// </summary>
        public const string SGCBDBCR = "SGCBDBCR";

        /// <summary>
        /// SGCBVLDT.
        /// </summary>
        public const string SGCBVLDT = "SGCBVLDT";

        /// <summary>
        /// SGCCRCD.
        /// </summary>
        public const string SGCCRCD = "SGCCRCD";

        /// <summary>
        /// SGCLBAA.
        /// </summary>
        public const string SGCLBAA = "SGCLBAA";

        /// <summary>
        /// SGCADBCR.
        /// </summary>
        public const string SGCADBCR = "SGCADBCR";

        /// <summary>
        /// SGCAVLDT.
        /// </summary>
        public const string SGCAVLDT = "SGCAVLDT";

        /// <summary>
        /// SGCACRCD.
        /// </summary>
        public const string SGCACRCD = "SGCACRCD";

        /// <summary>
        /// SGCAVAA.
        /// </summary>
        public const string SGCAVAA = "SGCAVAA";

        /// <summary>
        /// SGFADBCR.
        /// </summary>
        public const string SGFADBCR = "SGFADBCR";

        /// <summary>
        /// SGFVLDT.
        /// </summary>
        public const string SGFVLDT = "SGFVLDT";

        /// <summary>
        /// SGFACRCD.
        /// </summary>
        public const string SGFACRCD = "SGFACRCD";

        /// <summary>
        /// SGFAVAA.
        /// </summary>
        public const string SGFAVAA = "SGFAVAA";

        /// <summary>
        /// SGFIO.
        /// </summary>
        public const string SGFIO = "SGFIO";

        /// <summary>
        /// SGEFI.
        /// </summary>
        public const string SGEFI = "SGEFI";

        /// <summary>
        /// SGRECCODE.
        /// </summary>
        public const string SGRECCODE = "SGRECCODE";

        /// <summary>
        /// SGETRN.
        /// </summary>
        public const string SGETRN = "SGETRN";

        /// <summary>
        /// SGBSSID.
        /// </summary>
        public const string SGBSSID = "SGBSSID";

        /// <summary>
        /// SGBSRID.
        /// </summary>
        public const string SGBSRID = "SGBSRID";

        /// <summary>
        /// SGBSODF.
        /// </summary>
        public const string SGBSODF = "SGBSODF";

        /// <summary>
        /// SGBSTDF.
        /// </summary>
        public const string SGBSTDF = "SGBSTDF";

        /// <summary>
        /// SGOKPURGE.
        /// </summary>
        public const string SGOKPURGE = "SGOKPURGE";

        /// <summary>
        /// SGUSER.
        /// </summary>
        public const string SGUSER = "SGUSER";

        /// <summary>
        /// SGPID.
        /// </summary>
        public const string SGPID = "SGPID";

        /// <summary>
        /// SGJOBN.
        /// </summary>
        public const string SGJOBN = "SGJOBN";

        /// <summary>
        /// SGUPMT.
        /// </summary>
        public const string SGUPMT = "SGUPMT";

        /// <summary>
        /// SGUPMJ.
        /// </summary>
        public const string SGUPMJ = "SGUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F09610";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SGBSTN", "SGBSTN", JdeDataType.Numeric, null, true, true),
        new JdeField("SGSTMD", "SGSTMD", JdeDataType.Numeric, null, true, true),
        new JdeField("SGBAN", "SGBAN", JdeDataType.String, 58, true, true),
        new JdeField("SGBSSEQ", "SGBSSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("SGBKSTID", "SGBKSTID", JdeDataType.Numeric),
        new JdeField("SGMESST", "SGMESST", JdeDataType.String, 10),
        new JdeField("SGDESC04", "SGDESC04", JdeDataType.String, 90),
        new JdeField("SGOBDBCR", "SGOBDBCR", JdeDataType.String, 2),
        new JdeField("SGOLVDT", "SGOLVDT", JdeDataType.Numeric),
        new JdeField("SGOCRCD", "SGOCRCD", JdeDataType.String, 6),
        new JdeField("SGTCRCD", "SGTCRCD", JdeDataType.String, 6),
        new JdeField("SGOPBAA", "SGOPBAA", JdeDataType.Numeric),
        new JdeField("SGCBDBCR", "SGCBDBCR", JdeDataType.String, 2),
        new JdeField("SGCBVLDT", "SGCBVLDT", JdeDataType.Numeric),
        new JdeField("SGCCRCD", "SGCCRCD", JdeDataType.String, 6),
        new JdeField("SGCLBAA", "SGCLBAA", JdeDataType.Numeric),
        new JdeField("SGCADBCR", "SGCADBCR", JdeDataType.String, 2),
        new JdeField("SGCAVLDT", "SGCAVLDT", JdeDataType.Numeric),
        new JdeField("SGCACRCD", "SGCACRCD", JdeDataType.String, 6),
        new JdeField("SGCAVAA", "SGCAVAA", JdeDataType.Numeric),
        new JdeField("SGFADBCR", "SGFADBCR", JdeDataType.String, 2),
        new JdeField("SGFVLDT", "SGFVLDT", JdeDataType.Numeric),
        new JdeField("SGFACRCD", "SGFACRCD", JdeDataType.String, 6),
        new JdeField("SGFAVAA", "SGFAVAA", JdeDataType.Numeric),
        new JdeField("SGFIO", "SGFIO", JdeDataType.String, 2),
        new JdeField("SGEFI", "SGEFI", JdeDataType.String, 12),
        new JdeField("SGRECCODE", "SGRECCODE", JdeDataType.String, 2),
        new JdeField("SGETRN", "SGETRN", JdeDataType.String, 32),
        new JdeField("SGBSSID", "SGBSSID", JdeDataType.String, 18),
        new JdeField("SGBSRID", "SGBSRID", JdeDataType.String, 18),
        new JdeField("SGBSODF", "SGBSODF", JdeDataType.Numeric),
        new JdeField("SGBSTDF", "SGBSTDF", JdeDataType.Numeric),
        new JdeField("SGOKPURGE", "SGOKPURGE", JdeDataType.String, 2),
        new JdeField("SGUSER", "SGUSER", JdeDataType.String, 20),
        new JdeField("SGPID", "SGPID", JdeDataType.String, 20),
        new JdeField("SGJOBN", "SGJOBN", JdeDataType.String, 20),
        new JdeField("SGUPMT", "SGUPMT", JdeDataType.Numeric),
        new JdeField("SGUPMJ", "SGUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09610_0", "Primary Key on SGBSTN, SGSTMD, SGBAN, SGBSSEQ", new[] { "SGBSTN", "SGSTMD", "SGBAN", "SGBSSEQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F09610_2", "Index on SGBKSTID, SGBSSEQ", new[] { "SGBKSTID", "SGBSSEQ" }),
        new JdeIndex("F09610_3", "Index on SGOKPURGE, SGBSTN, SGSTMD, SGBAN", new[] { "SGOKPURGE", "SGBSTN", "SGSTMD", "SGBAN" })
    };
}
