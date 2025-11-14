using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08JDWF2 - .
/// </summary>
public class F08JDWF2 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JHOTPS.
        /// </summary>
        public const string JHOTPS = "JHOTPS";

        /// <summary>
        /// JHORMCU.
        /// </summary>
        public const string JHORMCU = "JHORMCU";

        /// <summary>
        /// JHJBCD.
        /// </summary>
        public const string JHJBCD = "JHJBCD";

        /// <summary>
        /// JHJBST.
        /// </summary>
        public const string JHJBST = "JHJBST";

        /// <summary>
        /// JHJCC.
        /// </summary>
        public const string JHJCC = "JHJCC";

        /// <summary>
        /// JHRULEN.
        /// </summary>
        public const string JHRULEN = "JHRULEN";

        /// <summary>
        /// JHCOPTN.
        /// </summary>
        public const string JHCOPTN = "JHCOPTN";

        /// <summary>
        /// JHCMPE.
        /// </summary>
        public const string JHCMPE = "JHCMPE";

        /// <summary>
        /// JHCMPC.
        /// </summary>
        public const string JHCMPC = "JHCMPC";

        /// <summary>
        /// JHLVWT.
        /// </summary>
        public const string JHLVWT = "JHLVWT";

        /// <summary>
        /// JHREQL.
        /// </summary>
        public const string JHREQL = "JHREQL";

        /// <summary>
        /// JHHIGHC.
        /// </summary>
        public const string JHHIGHC = "JHHIGHC";

        /// <summary>
        /// JHLOWC.
        /// </summary>
        public const string JHLOWC = "JHLOWC";

        /// <summary>
        /// JHEFTB.
        /// </summary>
        public const string JHEFTB = "JHEFTB";

        /// <summary>
        /// JHEFTE.
        /// </summary>
        public const string JHEFTE = "JHEFTE";

        /// <summary>
        /// JHPFMTH.
        /// </summary>
        public const string JHPFMTH = "JHPFMTH";

        /// <summary>
        /// JHJCCS.
        /// </summary>
        public const string JHJCCS = "JHJCCS";

        /// <summary>
        /// JHOVREX.
        /// </summary>
        public const string JHOVREX = "JHOVREX";

        /// <summary>
        /// JHINCLG.
        /// </summary>
        public const string JHINCLG = "JHINCLG";

        /// <summary>
        /// JHACCOMP.
        /// </summary>
        public const string JHACCOMP = "JHACCOMP";

        /// <summary>
        /// JHUSER.
        /// </summary>
        public const string JHUSER = "JHUSER";

        /// <summary>
        /// JHPID.
        /// </summary>
        public const string JHPID = "JHPID";

        /// <summary>
        /// JHUPMJ.
        /// </summary>
        public const string JHUPMJ = "JHUPMJ";

        /// <summary>
        /// JHUPMT.
        /// </summary>
        public const string JHUPMT = "JHUPMT";

        /// <summary>
        /// JHMKEY.
        /// </summary>
        public const string JHMKEY = "JHMKEY";

        /// <summary>
        /// JHEFT.
        /// </summary>
        public const string JHEFT = "JHEFT";
    }

    /// <inheritdoc />
    public override string TableName => "F08JDWF2";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JHOTPS", "JHOTPS", JdeDataType.String, 6, true, true),
        new JdeField("JHORMCU", "JHORMCU", JdeDataType.String, 24, true, true),
        new JdeField("JHJBCD", "JHJBCD", JdeDataType.String, 12, true, true),
        new JdeField("JHJBST", "JHJBST", JdeDataType.String, 8, true, true),
        new JdeField("JHJCC", "JHJCC", JdeDataType.String, 20, true, true),
        new JdeField("JHRULEN", "JHRULEN", JdeDataType.Numeric, null, true, true),
        new JdeField("JHCOPTN", "JHCOPTN", JdeDataType.String, 6),
        new JdeField("JHCMPE", "JHCMPE", JdeDataType.String, 6),
        new JdeField("JHCMPC", "JHCMPC", JdeDataType.String, 20),
        new JdeField("JHLVWT", "JHLVWT", JdeDataType.Numeric),
        new JdeField("JHREQL", "JHREQL", JdeDataType.Numeric),
        new JdeField("JHHIGHC", "JHHIGHC", JdeDataType.Numeric),
        new JdeField("JHLOWC", "JHLOWC", JdeDataType.Numeric),
        new JdeField("JHEFTB", "JHEFTB", JdeDataType.Numeric),
        new JdeField("JHEFTE", "JHEFTE", JdeDataType.Numeric),
        new JdeField("JHPFMTH", "JHPFMTH", JdeDataType.String, 2),
        new JdeField("JHJCCS", "JHJCCS", JdeDataType.String, 126),
        new JdeField("JHOVREX", "JHOVREX", JdeDataType.String, 2),
        new JdeField("JHINCLG", "JHINCLG", JdeDataType.Numeric),
        new JdeField("JHACCOMP", "JHACCOMP", JdeDataType.String, 2),
        new JdeField("JHUSER", "JHUSER", JdeDataType.String, 20),
        new JdeField("JHPID", "JHPID", JdeDataType.String, 20),
        new JdeField("JHUPMJ", "JHUPMJ", JdeDataType.Numeric),
        new JdeField("JHUPMT", "JHUPMT", JdeDataType.Numeric),
        new JdeField("JHMKEY", "JHMKEY", JdeDataType.String, 30),
        new JdeField("JHEFT", "JHEFT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08JDWF2_0", "Primary Key on JHOTPS, JHORMCU, JHJBCD, JHJBST, JHJCC, JHRULEN", new[] { "JHOTPS", "JHORMCU", "JHJBCD", "JHJBST", "JHJCC", "JHRULEN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08JDWF2_2", "Index on JHOTPS, JHORMCU, JHJBCD, JHJBST, SYS_NC00027$", new[] { "JHOTPS", "JHORMCU", "JHJBCD", "JHJBST", "SYS_NC00027$" }),
        new JdeIndex("F08JDWF2_3", "Index on JHOTPS, JHORMCU, JHJBCD, JHJBST, JHJCC, JHCOPTN, JHCMPE, JHCMPC", new[] { "JHOTPS", "JHORMCU", "JHJBCD", "JHJBST", "JHJCC", "JHCOPTN", "JHCMPE", "JHCMPC" })
    };
}
