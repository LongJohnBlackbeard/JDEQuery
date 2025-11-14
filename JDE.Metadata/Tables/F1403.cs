using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1403 - .
/// </summary>
public class F1403 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BDMCU.
        /// </summary>
        public const string BDMCU = "BDMCU";

        /// <summary>
        /// BDAID.
        /// </summary>
        public const string BDAID = "BDAID";

        /// <summary>
        /// BDRVNUM.
        /// </summary>
        public const string BDRVNUM = "BDRVNUM";

        /// <summary>
        /// BDDL01.
        /// </summary>
        public const string BDDL01 = "BDDL01";

        /// <summary>
        /// BDOBJ.
        /// </summary>
        public const string BDOBJ = "BDOBJ";

        /// <summary>
        /// BDSUB.
        /// </summary>
        public const string BDSUB = "BDSUB";

        /// <summary>
        /// BDCO.
        /// </summary>
        public const string BDCO = "BDCO";

        /// <summary>
        /// BDAN01.
        /// </summary>
        public const string BDAN01 = "BDAN01";

        /// <summary>
        /// BDAN02.
        /// </summary>
        public const string BDAN02 = "BDAN02";

        /// <summary>
        /// BDAN03.
        /// </summary>
        public const string BDAN03 = "BDAN03";

        /// <summary>
        /// BDAN04.
        /// </summary>
        public const string BDAN04 = "BDAN04";

        /// <summary>
        /// BDAN05.
        /// </summary>
        public const string BDAN05 = "BDAN05";

        /// <summary>
        /// BDAN06.
        /// </summary>
        public const string BDAN06 = "BDAN06";

        /// <summary>
        /// BDAN07.
        /// </summary>
        public const string BDAN07 = "BDAN07";

        /// <summary>
        /// BDAN08.
        /// </summary>
        public const string BDAN08 = "BDAN08";

        /// <summary>
        /// BDAN09.
        /// </summary>
        public const string BDAN09 = "BDAN09";

        /// <summary>
        /// BDAN10.
        /// </summary>
        public const string BDAN10 = "BDAN10";

        /// <summary>
        /// BDAN11.
        /// </summary>
        public const string BDAN11 = "BDAN11";

        /// <summary>
        /// BDAN12.
        /// </summary>
        public const string BDAN12 = "BDAN12";

        /// <summary>
        /// BDAN13.
        /// </summary>
        public const string BDAN13 = "BDAN13";

        /// <summary>
        /// BDAN14.
        /// </summary>
        public const string BDAN14 = "BDAN14";

        /// <summary>
        /// BDAA.
        /// </summary>
        public const string BDAA = "BDAA";

        /// <summary>
        /// BDBPC.
        /// </summary>
        public const string BDBPC = "BDBPC";

        /// <summary>
        /// BDGRWPC.
        /// </summary>
        public const string BDGRWPC = "BDGRWPC";

        /// <summary>
        /// BDLOCKFLG.
        /// </summary>
        public const string BDLOCKFLG = "BDLOCKFLG";

        /// <summary>
        /// BDUSER.
        /// </summary>
        public const string BDUSER = "BDUSER";

        /// <summary>
        /// BDPID.
        /// </summary>
        public const string BDPID = "BDPID";

        /// <summary>
        /// BDJOBN.
        /// </summary>
        public const string BDJOBN = "BDJOBN";

        /// <summary>
        /// BDUPMT.
        /// </summary>
        public const string BDUPMT = "BDUPMT";

        /// <summary>
        /// BDUPMJ.
        /// </summary>
        public const string BDUPMJ = "BDUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F1403";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BDMCU", "BDMCU", JdeDataType.String, 24, true, true),
        new JdeField("BDAID", "BDAID", JdeDataType.String, 16, true, true),
        new JdeField("BDRVNUM", "BDRVNUM", JdeDataType.String, 20, true, true),
        new JdeField("BDDL01", "BDDL01", JdeDataType.String, 60),
        new JdeField("BDOBJ", "BDOBJ", JdeDataType.String, 12),
        new JdeField("BDSUB", "BDSUB", JdeDataType.String, 16),
        new JdeField("BDCO", "BDCO", JdeDataType.String, 10),
        new JdeField("BDAN01", "BDAN01", JdeDataType.Numeric),
        new JdeField("BDAN02", "BDAN02", JdeDataType.Numeric),
        new JdeField("BDAN03", "BDAN03", JdeDataType.Numeric),
        new JdeField("BDAN04", "BDAN04", JdeDataType.Numeric),
        new JdeField("BDAN05", "BDAN05", JdeDataType.Numeric),
        new JdeField("BDAN06", "BDAN06", JdeDataType.Numeric),
        new JdeField("BDAN07", "BDAN07", JdeDataType.Numeric),
        new JdeField("BDAN08", "BDAN08", JdeDataType.Numeric),
        new JdeField("BDAN09", "BDAN09", JdeDataType.Numeric),
        new JdeField("BDAN10", "BDAN10", JdeDataType.Numeric),
        new JdeField("BDAN11", "BDAN11", JdeDataType.Numeric),
        new JdeField("BDAN12", "BDAN12", JdeDataType.Numeric),
        new JdeField("BDAN13", "BDAN13", JdeDataType.Numeric),
        new JdeField("BDAN14", "BDAN14", JdeDataType.Numeric),
        new JdeField("BDAA", "BDAA", JdeDataType.Numeric),
        new JdeField("BDBPC", "BDBPC", JdeDataType.String, 6),
        new JdeField("BDGRWPC", "BDGRWPC", JdeDataType.String, 20),
        new JdeField("BDLOCKFLG", "BDLOCKFLG", JdeDataType.String, 2),
        new JdeField("BDUSER", "BDUSER", JdeDataType.String, 20),
        new JdeField("BDPID", "BDPID", JdeDataType.String, 20),
        new JdeField("BDJOBN", "BDJOBN", JdeDataType.String, 20),
        new JdeField("BDUPMT", "BDUPMT", JdeDataType.Numeric),
        new JdeField("BDUPMJ", "BDUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1403_0", "Primary Key on BDMCU, BDAID, BDRVNUM", new[] { "BDMCU", "BDAID", "BDRVNUM" }, isUnique: true, isPrimaryKey: true)
    };
}
