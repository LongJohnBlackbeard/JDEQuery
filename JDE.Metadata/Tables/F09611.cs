using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09611 - .
/// </summary>
public class F09611 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BGBSTN.
        /// </summary>
        public const string BGBSTN = "BGBSTN";

        /// <summary>
        /// BGSTMD.
        /// </summary>
        public const string BGSTMD = "BGSTMD";

        /// <summary>
        /// BGBAN.
        /// </summary>
        public const string BGBAN = "BGBAN";

        /// <summary>
        /// BGBKSTID.
        /// </summary>
        public const string BGBKSTID = "BGBKSTID";

        /// <summary>
        /// BGSTLIN.
        /// </summary>
        public const string BGSTLIN = "BGSTLIN";

        /// <summary>
        /// BGBSSEQ.
        /// </summary>
        public const string BGBSSEQ = "BGBSSEQ";

        /// <summary>
        /// BGRECCODE.
        /// </summary>
        public const string BGRECCODE = "BGRECCODE";

        /// <summary>
        /// BGVLDT.
        /// </summary>
        public const string BGVLDT = "BGVLDT";

        /// <summary>
        /// BGBVLDT.
        /// </summary>
        public const string BGBVLDT = "BGBVLDT";

        /// <summary>
        /// BGDDBCR.
        /// </summary>
        public const string BGDDBCR = "BGDDBCR";

        /// <summary>
        /// BGTCRCD.
        /// </summary>
        public const string BGTCRCD = "BGTCRCD";

        /// <summary>
        /// BGCURRT.
        /// </summary>
        public const string BGCURRT = "BGCURRT";

        /// <summary>
        /// BGAA.
        /// </summary>
        public const string BGAA = "BGAA";

        /// <summary>
        /// BGTRANT.
        /// </summary>
        public const string BGTRANT = "BGTRANT";

        /// <summary>
        /// BGCUSTREF.
        /// </summary>
        public const string BGCUSTREF = "BGCUSTREF";

        /// <summary>
        /// BGBANKREF.
        /// </summary>
        public const string BGBANKREF = "BGBANKREF";

        /// <summary>
        /// BGEFI.
        /// </summary>
        public const string BGEFI = "BGEFI";

        /// <summary>
        /// BGSUBF9.
        /// </summary>
        public const string BGSUBF9 = "BGSUBF9";

        /// <summary>
        /// BGBSTEXT.
        /// </summary>
        public const string BGBSTEXT = "BGBSTEXT";

        /// <summary>
        /// BGINFO1.
        /// </summary>
        public const string BGINFO1 = "BGINFO1";

        /// <summary>
        /// BGUSER.
        /// </summary>
        public const string BGUSER = "BGUSER";

        /// <summary>
        /// BGPID.
        /// </summary>
        public const string BGPID = "BGPID";

        /// <summary>
        /// BGJOBN.
        /// </summary>
        public const string BGJOBN = "BGJOBN";

        /// <summary>
        /// BGUPMT.
        /// </summary>
        public const string BGUPMT = "BGUPMT";

        /// <summary>
        /// BGUPMJ.
        /// </summary>
        public const string BGUPMJ = "BGUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F09611";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BGBSTN", "BGBSTN", JdeDataType.Numeric, null, true, true),
        new JdeField("BGSTMD", "BGSTMD", JdeDataType.Numeric, null, true, true),
        new JdeField("BGBAN", "BGBAN", JdeDataType.String, 58, true, true),
        new JdeField("BGBKSTID", "BGBKSTID", JdeDataType.Numeric),
        new JdeField("BGSTLIN", "BGSTLIN", JdeDataType.Numeric, null, true, true),
        new JdeField("BGBSSEQ", "BGBSSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("BGRECCODE", "BGRECCODE", JdeDataType.String, 2),
        new JdeField("BGVLDT", "BGVLDT", JdeDataType.Numeric),
        new JdeField("BGBVLDT", "BGBVLDT", JdeDataType.String, 10),
        new JdeField("BGDDBCR", "BGDDBCR", JdeDataType.String, 4),
        new JdeField("BGTCRCD", "BGTCRCD", JdeDataType.String, 6),
        new JdeField("BGCURRT", "BGCURRT", JdeDataType.String, 2),
        new JdeField("BGAA", "BGAA", JdeDataType.Numeric),
        new JdeField("BGTRANT", "BGTRANT", JdeDataType.String, 8),
        new JdeField("BGCUSTREF", "BGCUSTREF", JdeDataType.String, 32),
        new JdeField("BGBANKREF", "BGBANKREF", JdeDataType.String, 32),
        new JdeField("BGEFI", "BGEFI", JdeDataType.String, 12),
        new JdeField("BGSUBF9", "BGSUBF9", JdeDataType.String, 68),
        new JdeField("BGBSTEXT", "BGBSTEXT", JdeDataType.String, 80),
        new JdeField("BGINFO1", "BGINFO1", JdeDataType.String, 780),
        new JdeField("BGUSER", "BGUSER", JdeDataType.String, 20),
        new JdeField("BGPID", "BGPID", JdeDataType.String, 20),
        new JdeField("BGJOBN", "BGJOBN", JdeDataType.String, 20),
        new JdeField("BGUPMT", "BGUPMT", JdeDataType.Numeric),
        new JdeField("BGUPMJ", "BGUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09611_0", "Primary Key on BGBSTN, BGSTMD, BGBAN, BGBSSEQ, BGSTLIN", new[] { "BGBSTN", "BGSTMD", "BGBAN", "BGBSSEQ", "BGSTLIN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F09611_2", "Index on BGBKSTID, BGBSSEQ, BGSTLIN", new[] { "BGBKSTID", "BGBSSEQ", "BGSTLIN" }),
        new JdeIndex("F09611_3", "Index on BGBSTN, BGSTMD, BGBAN, BGSTLIN, BGTRANT", new[] { "BGBSTN", "BGSTMD", "BGBAN", "BGSTLIN", "BGTRANT" })
    };
}
