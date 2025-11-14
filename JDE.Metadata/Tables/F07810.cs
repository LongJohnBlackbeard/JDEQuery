using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07810 - .
/// </summary>
public class F07810 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JEIDYE.
        /// </summary>
        public const string JEIDYE = "JEIDYE";

        /// <summary>
        /// JEDTEY.
        /// </summary>
        public const string JEDTEY = "JEDTEY";

        /// <summary>
        /// JEPTYE.
        /// </summary>
        public const string JEPTYE = "JEPTYE";

        /// <summary>
        /// JEVTYE.
        /// </summary>
        public const string JEVTYE = "JEVTYE";

        /// <summary>
        /// JEVERS.
        /// </summary>
        public const string JEVERS = "JEVERS";

        /// <summary>
        /// JETIS.
        /// </summary>
        public const string JETIS = "JETIS";

        /// <summary>
        /// JESSDL.
        /// </summary>
        public const string JESSDL = "JESSDL";

        /// <summary>
        /// JEMDDL.
        /// </summary>
        public const string JEMDDL = "JEMDDL";

        /// <summary>
        /// JET1DL.
        /// </summary>
        public const string JET1DL = "JET1DL";

        /// <summary>
        /// JET2DL.
        /// </summary>
        public const string JET2DL = "JET2DL";

        /// <summary>
        /// JETAPD.
        /// </summary>
        public const string JETAPD = "JETAPD";

        /// <summary>
        /// JEMMFI.
        /// </summary>
        public const string JEMMFI = "JEMMFI";

        /// <summary>
        /// JEDEVN.
        /// </summary>
        public const string JEDEVN = "JEDEVN";

        /// <summary>
        /// JEW2LC.
        /// </summary>
        public const string JEW2LC = "JEW2LC";

        /// <summary>
        /// JEW2NF.
        /// </summary>
        public const string JEW2NF = "JEW2NF";

        /// <summary>
        /// JEW2PS.
        /// </summary>
        public const string JEW2PS = "JEW2PS";

        /// <summary>
        /// JEW2FI.
        /// </summary>
        public const string JEW2FI = "JEW2FI";

        /// <summary>
        /// JEW2AW.
        /// </summary>
        public const string JEW2AW = "JEW2AW";

        /// <summary>
        /// JEW22S.
        /// </summary>
        public const string JEW22S = "JEW22S";

        /// <summary>
        /// JEFS01.
        /// </summary>
        public const string JEFS01 = "JEFS01";

        /// <summary>
        /// JEFS02.
        /// </summary>
        public const string JEFS02 = "JEFS02";

        /// <summary>
        /// JEFS03.
        /// </summary>
        public const string JEFS03 = "JEFS03";

        /// <summary>
        /// JEFS04.
        /// </summary>
        public const string JEFS04 = "JEFS04";

        /// <summary>
        /// JEFS05.
        /// </summary>
        public const string JEFS05 = "JEFS05";

        /// <summary>
        /// JEFS06.
        /// </summary>
        public const string JEFS06 = "JEFS06";

        /// <summary>
        /// JEFS07.
        /// </summary>
        public const string JEFS07 = "JEFS07";

        /// <summary>
        /// JEFS08.
        /// </summary>
        public const string JEFS08 = "JEFS08";

        /// <summary>
        /// JEFS09.
        /// </summary>
        public const string JEFS09 = "JEFS09";

        /// <summary>
        /// JEFS10.
        /// </summary>
        public const string JEFS10 = "JEFS10";

        /// <summary>
        /// JEFS11.
        /// </summary>
        public const string JEFS11 = "JEFS11";

        /// <summary>
        /// JEFS12.
        /// </summary>
        public const string JEFS12 = "JEFS12";

        /// <summary>
        /// JEFS13.
        /// </summary>
        public const string JEFS13 = "JEFS13";

        /// <summary>
        /// JEFS14.
        /// </summary>
        public const string JEFS14 = "JEFS14";

        /// <summary>
        /// JEFS15.
        /// </summary>
        public const string JEFS15 = "JEFS15";

        /// <summary>
        /// JEST17.
        /// </summary>
        public const string JEST17 = "JEST17";

        /// <summary>
        /// JESEQC.
        /// </summary>
        public const string JESEQC = "JESEQC";

        /// <summary>
        /// JEAN8T.
        /// </summary>
        public const string JEAN8T = "JEAN8T";

        /// <summary>
        /// JEAN8N.
        /// </summary>
        public const string JEAN8N = "JEAN8N";

        /// <summary>
        /// JEWAN8.
        /// </summary>
        public const string JEWAN8 = "JEWAN8";

        /// <summary>
        /// JEAN8D.
        /// </summary>
        public const string JEAN8D = "JEAN8D";

        /// <summary>
        /// JEFO01.
        /// </summary>
        public const string JEFO01 = "JEFO01";

        /// <summary>
        /// JEFO02.
        /// </summary>
        public const string JEFO02 = "JEFO02";

        /// <summary>
        /// JEFO03.
        /// </summary>
        public const string JEFO03 = "JEFO03";

        /// <summary>
        /// JEFO04.
        /// </summary>
        public const string JEFO04 = "JEFO04";

        /// <summary>
        /// JEFO05.
        /// </summary>
        public const string JEFO05 = "JEFO05";

        /// <summary>
        /// JERNUM.
        /// </summary>
        public const string JERNUM = "JERNUM";

        /// <summary>
        /// JEBFTR.
        /// </summary>
        public const string JEBFTR = "JEBFTR";

        /// <summary>
        /// JEUPMJ.
        /// </summary>
        public const string JEUPMJ = "JEUPMJ";

        /// <summary>
        /// JEUPMT.
        /// </summary>
        public const string JEUPMT = "JEUPMT";

        /// <summary>
        /// JEPID.
        /// </summary>
        public const string JEPID = "JEPID";

        /// <summary>
        /// JEJOBN.
        /// </summary>
        public const string JEJOBN = "JEJOBN";

        /// <summary>
        /// JEUSER.
        /// </summary>
        public const string JEUSER = "JEUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F07810";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JEIDYE", "JEIDYE", JdeDataType.String, 20, true, true),
        new JdeField("JEDTEY", "JEDTEY", JdeDataType.Numeric, null, true, true),
        new JdeField("JEPTYE", "JEPTYE", JdeDataType.String, 2),
        new JdeField("JEVTYE", "JEVTYE", JdeDataType.String, 2),
        new JdeField("JEVERS", "JEVERS", JdeDataType.String, 20),
        new JdeField("JETIS", "JETIS", JdeDataType.String, 2),
        new JdeField("JESSDL", "JESSDL", JdeDataType.Numeric),
        new JdeField("JEMDDL", "JEMDDL", JdeDataType.Numeric),
        new JdeField("JET1DL", "JET1DL", JdeDataType.Numeric),
        new JdeField("JET2DL", "JET2DL", JdeDataType.Numeric),
        new JdeField("JETAPD", "JETAPD", JdeDataType.Numeric),
        new JdeField("JEMMFI", "JEMMFI", JdeDataType.String, 20),
        new JdeField("JEDEVN", "JEDEVN", JdeDataType.String, 20),
        new JdeField("JEW2LC", "JEW2LC", JdeDataType.Numeric),
        new JdeField("JEW2NF", "JEW2NF", JdeDataType.String, 2),
        new JdeField("JEW2PS", "JEW2PS", JdeDataType.String, 2),
        new JdeField("JEW2FI", "JEW2FI", JdeDataType.String, 2),
        new JdeField("JEW2AW", "JEW2AW", JdeDataType.String, 2),
        new JdeField("JEW22S", "JEW22S", JdeDataType.String, 2),
        new JdeField("JEFS01", "JEFS01", JdeDataType.String, 2),
        new JdeField("JEFS02", "JEFS02", JdeDataType.String, 2),
        new JdeField("JEFS03", "JEFS03", JdeDataType.String, 2),
        new JdeField("JEFS04", "JEFS04", JdeDataType.String, 2),
        new JdeField("JEFS05", "JEFS05", JdeDataType.String, 2),
        new JdeField("JEFS06", "JEFS06", JdeDataType.String, 2),
        new JdeField("JEFS07", "JEFS07", JdeDataType.String, 2),
        new JdeField("JEFS08", "JEFS08", JdeDataType.String, 2),
        new JdeField("JEFS09", "JEFS09", JdeDataType.String, 2),
        new JdeField("JEFS10", "JEFS10", JdeDataType.String, 2),
        new JdeField("JEFS11", "JEFS11", JdeDataType.String, 2),
        new JdeField("JEFS12", "JEFS12", JdeDataType.String, 2),
        new JdeField("JEFS13", "JEFS13", JdeDataType.String, 2),
        new JdeField("JEFS14", "JEFS14", JdeDataType.String, 2),
        new JdeField("JEFS15", "JEFS15", JdeDataType.String, 2),
        new JdeField("JEST17", "JEST17", JdeDataType.String, 2),
        new JdeField("JESEQC", "JESEQC", JdeDataType.String, 2),
        new JdeField("JEAN8T", "JEAN8T", JdeDataType.Numeric),
        new JdeField("JEAN8N", "JEAN8N", JdeDataType.Numeric),
        new JdeField("JEWAN8", "JEWAN8", JdeDataType.Numeric),
        new JdeField("JEAN8D", "JEAN8D", JdeDataType.Numeric),
        new JdeField("JEFO01", "JEFO01", JdeDataType.String, 2),
        new JdeField("JEFO02", "JEFO02", JdeDataType.String, 2),
        new JdeField("JEFO03", "JEFO03", JdeDataType.String, 2),
        new JdeField("JEFO04", "JEFO04", JdeDataType.String, 2),
        new JdeField("JEFO05", "JEFO05", JdeDataType.String, 2),
        new JdeField("JERNUM", "JERNUM", JdeDataType.Numeric),
        new JdeField("JEBFTR", "JEBFTR", JdeDataType.String, 2),
        new JdeField("JEUPMJ", "JEUPMJ", JdeDataType.Numeric),
        new JdeField("JEUPMT", "JEUPMT", JdeDataType.Numeric),
        new JdeField("JEPID", "JEPID", JdeDataType.String, 20),
        new JdeField("JEJOBN", "JEJOBN", JdeDataType.String, 20),
        new JdeField("JEUSER", "JEUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07810_0", "Primary Key on JEIDYE, JEDTEY", new[] { "JEIDYE", "JEDTEY" }, isUnique: true, isPrimaryKey: true)
    };
}
