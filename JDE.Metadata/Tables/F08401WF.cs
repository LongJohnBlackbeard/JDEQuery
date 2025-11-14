using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08401WF - .
/// </summary>
public class F08401WF : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// XNAN8.
        /// </summary>
        public const string XNAN8 = "XNAN8";

        /// <summary>
        /// XNJOBS.
        /// </summary>
        public const string XNJOBS = "XNJOBS";

        /// <summary>
        /// XNALPH.
        /// </summary>
        public const string XNALPH = "XNALPH";

        /// <summary>
        /// XNAPS.
        /// </summary>
        public const string XNAPS = "XNAPS";

        /// <summary>
        /// XNSSN.
        /// </summary>
        public const string XNSSN = "XNSSN";

        /// <summary>
        /// XNMCU.
        /// </summary>
        public const string XNMCU = "XNMCU";

        /// <summary>
        /// XNPOS.
        /// </summary>
        public const string XNPOS = "XNPOS";

        /// <summary>
        /// XNJBCD.
        /// </summary>
        public const string XNJBCD = "XNJBCD";

        /// <summary>
        /// XNJBST.
        /// </summary>
        public const string XNJBST = "XNJBST";

        /// <summary>
        /// XNEEOJ.
        /// </summary>
        public const string XNEEOJ = "XNEEOJ";

        /// <summary>
        /// XNEEOM.
        /// </summary>
        public const string XNEEOM = "XNEEOM";

        /// <summary>
        /// XNSEX.
        /// </summary>
        public const string XNSEX = "XNSEX";

        /// <summary>
        /// XNHM01.
        /// </summary>
        public const string XNHM01 = "XNHM01";

        /// <summary>
        /// XNHM02.
        /// </summary>
        public const string XNHM02 = "XNHM02";

        /// <summary>
        /// XNHM03.
        /// </summary>
        public const string XNHM03 = "XNHM03";

        /// <summary>
        /// XNHM04.
        /// </summary>
        public const string XNHM04 = "XNHM04";

        /// <summary>
        /// XNHM05.
        /// </summary>
        public const string XNHM05 = "XNHM05";

        /// <summary>
        /// XNHM06.
        /// </summary>
        public const string XNHM06 = "XNHM06";

        /// <summary>
        /// XNHM07.
        /// </summary>
        public const string XNHM07 = "XNHM07";

        /// <summary>
        /// XNHM08.
        /// </summary>
        public const string XNHM08 = "XNHM08";

        /// <summary>
        /// XNHM09.
        /// </summary>
        public const string XNHM09 = "XNHM09";

        /// <summary>
        /// XNHM10.
        /// </summary>
        public const string XNHM10 = "XNHM10";

        /// <summary>
        /// XNHN01.
        /// </summary>
        public const string XNHN01 = "XNHN01";

        /// <summary>
        /// XNHN02.
        /// </summary>
        public const string XNHN02 = "XNHN02";

        /// <summary>
        /// XNHN03.
        /// </summary>
        public const string XNHN03 = "XNHN03";

        /// <summary>
        /// XNHN04.
        /// </summary>
        public const string XNHN04 = "XNHN04";

        /// <summary>
        /// XNHN05.
        /// </summary>
        public const string XNHN05 = "XNHN05";

        /// <summary>
        /// XNHN06.
        /// </summary>
        public const string XNHN06 = "XNHN06";

        /// <summary>
        /// XNHN07.
        /// </summary>
        public const string XNHN07 = "XNHN07";

        /// <summary>
        /// XNHN08.
        /// </summary>
        public const string XNHN08 = "XNHN08";

        /// <summary>
        /// XNHN09.
        /// </summary>
        public const string XNHN09 = "XNHN09";

        /// <summary>
        /// XNHN10.
        /// </summary>
        public const string XNHN10 = "XNHN10";

        /// <summary>
        /// XNDOB.
        /// </summary>
        public const string XNDOB = "XNDOB";

        /// <summary>
        /// XNRECB.
        /// </summary>
        public const string XNRECB = "XNRECB";

        /// <summary>
        /// XNRECE.
        /// </summary>
        public const string XNRECE = "XNRECE";

        /// <summary>
        /// XNDFIN.
        /// </summary>
        public const string XNDFIN = "XNDFIN";

        /// <summary>
        /// XNDTAV.
        /// </summary>
        public const string XNDTAV = "XNDTAV";

        /// <summary>
        /// XNSALA.
        /// </summary>
        public const string XNSALA = "XNSALA";

        /// <summary>
        /// XNHRA.
        /// </summary>
        public const string XNHRA = "XNHRA";

        /// <summary>
        /// XNUSER.
        /// </summary>
        public const string XNUSER = "XNUSER";

        /// <summary>
        /// XNPID.
        /// </summary>
        public const string XNPID = "XNPID";

        /// <summary>
        /// XNUPMJ.
        /// </summary>
        public const string XNUPMJ = "XNUPMJ";

        /// <summary>
        /// XNJOBN.
        /// </summary>
        public const string XNJOBN = "XNJOBN";

        /// <summary>
        /// XNHMCU.
        /// </summary>
        public const string XNHMCU = "XNHMCU";

        /// <summary>
        /// XNEV01.
        /// </summary>
        public const string XNEV01 = "XNEV01";
    }

    /// <inheritdoc />
    public override string TableName => "F08401WF";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("XNAN8", "XNAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("XNJOBS", "XNJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("XNALPH", "XNALPH", JdeDataType.String, 80),
        new JdeField("XNAPS", "XNAPS", JdeDataType.String, 4),
        new JdeField("XNSSN", "XNSSN", JdeDataType.String, 40),
        new JdeField("XNMCU", "XNMCU", JdeDataType.String, 24),
        new JdeField("XNPOS", "XNPOS", JdeDataType.String, 16),
        new JdeField("XNJBCD", "XNJBCD", JdeDataType.String, 12),
        new JdeField("XNJBST", "XNJBST", JdeDataType.String, 8),
        new JdeField("XNEEOJ", "XNEEOJ", JdeDataType.String, 6),
        new JdeField("XNEEOM", "XNEEOM", JdeDataType.String, 4),
        new JdeField("XNSEX", "XNSEX", JdeDataType.String, 2),
        new JdeField("XNHM01", "XNHM01", JdeDataType.String, 2),
        new JdeField("XNHM02", "XNHM02", JdeDataType.String, 2),
        new JdeField("XNHM03", "XNHM03", JdeDataType.String, 2),
        new JdeField("XNHM04", "XNHM04", JdeDataType.String, 2),
        new JdeField("XNHM05", "XNHM05", JdeDataType.String, 2),
        new JdeField("XNHM06", "XNHM06", JdeDataType.String, 2),
        new JdeField("XNHM07", "XNHM07", JdeDataType.String, 2),
        new JdeField("XNHM08", "XNHM08", JdeDataType.String, 2),
        new JdeField("XNHM09", "XNHM09", JdeDataType.String, 2),
        new JdeField("XNHM10", "XNHM10", JdeDataType.String, 2),
        new JdeField("XNHN01", "XNHN01", JdeDataType.String, 6),
        new JdeField("XNHN02", "XNHN02", JdeDataType.String, 6),
        new JdeField("XNHN03", "XNHN03", JdeDataType.String, 6),
        new JdeField("XNHN04", "XNHN04", JdeDataType.String, 6),
        new JdeField("XNHN05", "XNHN05", JdeDataType.String, 6),
        new JdeField("XNHN06", "XNHN06", JdeDataType.String, 6),
        new JdeField("XNHN07", "XNHN07", JdeDataType.String, 6),
        new JdeField("XNHN08", "XNHN08", JdeDataType.String, 6),
        new JdeField("XNHN09", "XNHN09", JdeDataType.String, 6),
        new JdeField("XNHN10", "XNHN10", JdeDataType.String, 6),
        new JdeField("XNDOB", "XNDOB", JdeDataType.Numeric),
        new JdeField("XNRECB", "XNRECB", JdeDataType.Numeric),
        new JdeField("XNRECE", "XNRECE", JdeDataType.Numeric),
        new JdeField("XNDFIN", "XNDFIN", JdeDataType.Numeric),
        new JdeField("XNDTAV", "XNDTAV", JdeDataType.Numeric),
        new JdeField("XNSALA", "XNSALA", JdeDataType.Numeric),
        new JdeField("XNHRA", "XNHRA", JdeDataType.Numeric),
        new JdeField("XNUSER", "XNUSER", JdeDataType.String, 20),
        new JdeField("XNPID", "XNPID", JdeDataType.String, 20),
        new JdeField("XNUPMJ", "XNUPMJ", JdeDataType.Numeric),
        new JdeField("XNJOBN", "XNJOBN", JdeDataType.String, 20),
        new JdeField("XNHMCU", "XNHMCU", JdeDataType.String, 24),
        new JdeField("XNEV01", "XNEV01", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08401WF_0", "Primary Key on XNAN8, XNJOBS", new[] { "XNAN8", "XNJOBS" }, isUnique: true, isPrimaryKey: true)
    };
}
