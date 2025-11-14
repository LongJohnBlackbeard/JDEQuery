using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75C902 - .
/// </summary>
public class F75C902 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SBAID.
        /// </summary>
        public const string SBAID = "SBAID";

        /// <summary>
        /// SBCTRY.
        /// </summary>
        public const string SBCTRY = "SBCTRY";

        /// <summary>
        /// SBFY.
        /// </summary>
        public const string SBFY = "SBFY";

        /// <summary>
        /// SBLT.
        /// </summary>
        public const string SBLT = "SBLT";

        /// <summary>
        /// SBSBLT.
        /// </summary>
        public const string SBSBLT = "SBSBLT";

        /// <summary>
        /// SBSBL.
        /// </summary>
        public const string SBSBL = "SBSBL";

        /// <summary>
        /// SBCRCD.
        /// </summary>
        public const string SBCRCD = "SBCRCD";

        /// <summary>
        /// SBC75SUB1.
        /// </summary>
        public const string SBC75SUB1 = "SBC75SUB1";

        /// <summary>
        /// SBC75SUB2.
        /// </summary>
        public const string SBC75SUB2 = "SBC75SUB2";

        /// <summary>
        /// SBC75SUB3.
        /// </summary>
        public const string SBC75SUB3 = "SBC75SUB3";

        /// <summary>
        /// SBC75SUB4.
        /// </summary>
        public const string SBC75SUB4 = "SBC75SUB4";

        /// <summary>
        /// SBC75SUB5.
        /// </summary>
        public const string SBC75SUB5 = "SBC75SUB5";

        /// <summary>
        /// SBC75SUB6.
        /// </summary>
        public const string SBC75SUB6 = "SBC75SUB6";

        /// <summary>
        /// SBC75SUB7.
        /// </summary>
        public const string SBC75SUB7 = "SBC75SUB7";

        /// <summary>
        /// SBC75SUB8.
        /// </summary>
        public const string SBC75SUB8 = "SBC75SUB8";

        /// <summary>
        /// SBC75SUB9.
        /// </summary>
        public const string SBC75SUB9 = "SBC75SUB9";

        /// <summary>
        /// SBC75SUB10.
        /// </summary>
        public const string SBC75SUB10 = "SBC75SUB10";

        /// <summary>
        /// SBC75SUB11.
        /// </summary>
        public const string SBC75SUB11 = "SBC75SUB11";

        /// <summary>
        /// SBC75SUB12.
        /// </summary>
        public const string SBC75SUB12 = "SBC75SUB12";

        /// <summary>
        /// SBC75SUB13.
        /// </summary>
        public const string SBC75SUB13 = "SBC75SUB13";

        /// <summary>
        /// SBC75SUB14.
        /// </summary>
        public const string SBC75SUB14 = "SBC75SUB14";

        /// <summary>
        /// SBC75SUB15.
        /// </summary>
        public const string SBC75SUB15 = "SBC75SUB15";

        /// <summary>
        /// SBC75SUB16.
        /// </summary>
        public const string SBC75SUB16 = "SBC75SUB16";

        /// <summary>
        /// SBC75SUB17.
        /// </summary>
        public const string SBC75SUB17 = "SBC75SUB17";

        /// <summary>
        /// SBC75SUB18.
        /// </summary>
        public const string SBC75SUB18 = "SBC75SUB18";

        /// <summary>
        /// SBC75SUB19.
        /// </summary>
        public const string SBC75SUB19 = "SBC75SUB19";

        /// <summary>
        /// SBC75SUB20.
        /// </summary>
        public const string SBC75SUB20 = "SBC75SUB20";

        /// <summary>
        /// SBC75SUB21.
        /// </summary>
        public const string SBC75SUB21 = "SBC75SUB21";

        /// <summary>
        /// SBC75SUB22.
        /// </summary>
        public const string SBC75SUB22 = "SBC75SUB22";

        /// <summary>
        /// SBC75SUB23.
        /// </summary>
        public const string SBC75SUB23 = "SBC75SUB23";

        /// <summary>
        /// SBC75SUB24.
        /// </summary>
        public const string SBC75SUB24 = "SBC75SUB24";

        /// <summary>
        /// SBC75SUB25.
        /// </summary>
        public const string SBC75SUB25 = "SBC75SUB25";

        /// <summary>
        /// SBC75SUB26.
        /// </summary>
        public const string SBC75SUB26 = "SBC75SUB26";

        /// <summary>
        /// SBC75SUB27.
        /// </summary>
        public const string SBC75SUB27 = "SBC75SUB27";

        /// <summary>
        /// SBC75SUB28.
        /// </summary>
        public const string SBC75SUB28 = "SBC75SUB28";

        /// <summary>
        /// SBC75SUB29.
        /// </summary>
        public const string SBC75SUB29 = "SBC75SUB29";

        /// <summary>
        /// SBC75SUB30.
        /// </summary>
        public const string SBC75SUB30 = "SBC75SUB30";

        /// <summary>
        /// SBAPYC.
        /// </summary>
        public const string SBAPYC = "SBAPYC";

        /// <summary>
        /// SBAN01.
        /// </summary>
        public const string SBAN01 = "SBAN01";

        /// <summary>
        /// SBAN02.
        /// </summary>
        public const string SBAN02 = "SBAN02";

        /// <summary>
        /// SBAN03.
        /// </summary>
        public const string SBAN03 = "SBAN03";

        /// <summary>
        /// SBAN04.
        /// </summary>
        public const string SBAN04 = "SBAN04";

        /// <summary>
        /// SBAN05.
        /// </summary>
        public const string SBAN05 = "SBAN05";

        /// <summary>
        /// SBAN06.
        /// </summary>
        public const string SBAN06 = "SBAN06";

        /// <summary>
        /// SBAN07.
        /// </summary>
        public const string SBAN07 = "SBAN07";

        /// <summary>
        /// SBAN08.
        /// </summary>
        public const string SBAN08 = "SBAN08";

        /// <summary>
        /// SBAN09.
        /// </summary>
        public const string SBAN09 = "SBAN09";

        /// <summary>
        /// SBAN10.
        /// </summary>
        public const string SBAN10 = "SBAN10";

        /// <summary>
        /// SBAN11.
        /// </summary>
        public const string SBAN11 = "SBAN11";

        /// <summary>
        /// SBAN12.
        /// </summary>
        public const string SBAN12 = "SBAN12";

        /// <summary>
        /// SBAN13.
        /// </summary>
        public const string SBAN13 = "SBAN13";

        /// <summary>
        /// SBAN14.
        /// </summary>
        public const string SBAN14 = "SBAN14";

        /// <summary>
        /// SBAPYN.
        /// </summary>
        public const string SBAPYN = "SBAPYN";

        /// <summary>
        /// SBAND01.
        /// </summary>
        public const string SBAND01 = "SBAND01";

        /// <summary>
        /// SBAND02.
        /// </summary>
        public const string SBAND02 = "SBAND02";

        /// <summary>
        /// SBAND03.
        /// </summary>
        public const string SBAND03 = "SBAND03";

        /// <summary>
        /// SBAND04.
        /// </summary>
        public const string SBAND04 = "SBAND04";

        /// <summary>
        /// SBAND05.
        /// </summary>
        public const string SBAND05 = "SBAND05";

        /// <summary>
        /// SBAND06.
        /// </summary>
        public const string SBAND06 = "SBAND06";

        /// <summary>
        /// SBAND07.
        /// </summary>
        public const string SBAND07 = "SBAND07";

        /// <summary>
        /// SBAND08.
        /// </summary>
        public const string SBAND08 = "SBAND08";

        /// <summary>
        /// SBAND09.
        /// </summary>
        public const string SBAND09 = "SBAND09";

        /// <summary>
        /// SBAND10.
        /// </summary>
        public const string SBAND10 = "SBAND10";

        /// <summary>
        /// SBAND11.
        /// </summary>
        public const string SBAND11 = "SBAND11";

        /// <summary>
        /// SBAND12.
        /// </summary>
        public const string SBAND12 = "SBAND12";

        /// <summary>
        /// SBAND13.
        /// </summary>
        public const string SBAND13 = "SBAND13";

        /// <summary>
        /// SBAND14.
        /// </summary>
        public const string SBAND14 = "SBAND14";

        /// <summary>
        /// SBWEA1.
        /// </summary>
        public const string SBWEA1 = "SBWEA1";

        /// <summary>
        /// SBC75INID.
        /// </summary>
        public const string SBC75INID = "SBC75INID";

        /// <summary>
        /// SBFUTMATH1.
        /// </summary>
        public const string SBFUTMATH1 = "SBFUTMATH1";

        /// <summary>
        /// SBFUTSTR1.
        /// </summary>
        public const string SBFUTSTR1 = "SBFUTSTR1";

        /// <summary>
        /// SBFUTDATE1.
        /// </summary>
        public const string SBFUTDATE1 = "SBFUTDATE1";

        /// <summary>
        /// SBFUTUO1.
        /// </summary>
        public const string SBFUTUO1 = "SBFUTUO1";

        /// <summary>
        /// SBUSER.
        /// </summary>
        public const string SBUSER = "SBUSER";

        /// <summary>
        /// SBPID.
        /// </summary>
        public const string SBPID = "SBPID";

        /// <summary>
        /// SBJOBN.
        /// </summary>
        public const string SBJOBN = "SBJOBN";

        /// <summary>
        /// SBUPMJ.
        /// </summary>
        public const string SBUPMJ = "SBUPMJ";

        /// <summary>
        /// SBUPMT.
        /// </summary>
        public const string SBUPMT = "SBUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75C902";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SBAID", "SBAID", JdeDataType.String, 16, true, true),
        new JdeField("SBCTRY", "SBCTRY", JdeDataType.Numeric, null, true, true),
        new JdeField("SBFY", "SBFY", JdeDataType.Numeric, null, true, true),
        new JdeField("SBLT", "SBLT", JdeDataType.String, 4, true, true),
        new JdeField("SBSBLT", "SBSBLT", JdeDataType.String, 2, true, true),
        new JdeField("SBSBL", "SBSBL", JdeDataType.String, 16, true, true),
        new JdeField("SBCRCD", "SBCRCD", JdeDataType.String, 6, true, true),
        new JdeField("SBC75SUB1", "SBC75SUB1", JdeDataType.String, 120),
        new JdeField("SBC75SUB2", "SBC75SUB2", JdeDataType.String, 120),
        new JdeField("SBC75SUB3", "SBC75SUB3", JdeDataType.String, 120),
        new JdeField("SBC75SUB4", "SBC75SUB4", JdeDataType.String, 120),
        new JdeField("SBC75SUB5", "SBC75SUB5", JdeDataType.String, 120),
        new JdeField("SBC75SUB6", "SBC75SUB6", JdeDataType.String, 120),
        new JdeField("SBC75SUB7", "SBC75SUB7", JdeDataType.String, 120),
        new JdeField("SBC75SUB8", "SBC75SUB8", JdeDataType.String, 120),
        new JdeField("SBC75SUB9", "SBC75SUB9", JdeDataType.String, 120),
        new JdeField("SBC75SUB10", "SBC75SUB10", JdeDataType.String, 120),
        new JdeField("SBC75SUB11", "SBC75SUB11", JdeDataType.String, 120),
        new JdeField("SBC75SUB12", "SBC75SUB12", JdeDataType.String, 120),
        new JdeField("SBC75SUB13", "SBC75SUB13", JdeDataType.String, 120),
        new JdeField("SBC75SUB14", "SBC75SUB14", JdeDataType.String, 120),
        new JdeField("SBC75SUB15", "SBC75SUB15", JdeDataType.String, 120),
        new JdeField("SBC75SUB16", "SBC75SUB16", JdeDataType.String, 120),
        new JdeField("SBC75SUB17", "SBC75SUB17", JdeDataType.String, 120),
        new JdeField("SBC75SUB18", "SBC75SUB18", JdeDataType.String, 120),
        new JdeField("SBC75SUB19", "SBC75SUB19", JdeDataType.String, 120),
        new JdeField("SBC75SUB20", "SBC75SUB20", JdeDataType.String, 120),
        new JdeField("SBC75SUB21", "SBC75SUB21", JdeDataType.String, 120),
        new JdeField("SBC75SUB22", "SBC75SUB22", JdeDataType.String, 120),
        new JdeField("SBC75SUB23", "SBC75SUB23", JdeDataType.String, 120),
        new JdeField("SBC75SUB24", "SBC75SUB24", JdeDataType.String, 120),
        new JdeField("SBC75SUB25", "SBC75SUB25", JdeDataType.String, 120),
        new JdeField("SBC75SUB26", "SBC75SUB26", JdeDataType.String, 120),
        new JdeField("SBC75SUB27", "SBC75SUB27", JdeDataType.String, 120),
        new JdeField("SBC75SUB28", "SBC75SUB28", JdeDataType.String, 120),
        new JdeField("SBC75SUB29", "SBC75SUB29", JdeDataType.String, 120),
        new JdeField("SBC75SUB30", "SBC75SUB30", JdeDataType.String, 120),
        new JdeField("SBAPYC", "SBAPYC", JdeDataType.Numeric),
        new JdeField("SBAN01", "SBAN01", JdeDataType.Numeric),
        new JdeField("SBAN02", "SBAN02", JdeDataType.Numeric),
        new JdeField("SBAN03", "SBAN03", JdeDataType.Numeric),
        new JdeField("SBAN04", "SBAN04", JdeDataType.Numeric),
        new JdeField("SBAN05", "SBAN05", JdeDataType.Numeric),
        new JdeField("SBAN06", "SBAN06", JdeDataType.Numeric),
        new JdeField("SBAN07", "SBAN07", JdeDataType.Numeric),
        new JdeField("SBAN08", "SBAN08", JdeDataType.Numeric),
        new JdeField("SBAN09", "SBAN09", JdeDataType.Numeric),
        new JdeField("SBAN10", "SBAN10", JdeDataType.Numeric),
        new JdeField("SBAN11", "SBAN11", JdeDataType.Numeric),
        new JdeField("SBAN12", "SBAN12", JdeDataType.Numeric),
        new JdeField("SBAN13", "SBAN13", JdeDataType.Numeric),
        new JdeField("SBAN14", "SBAN14", JdeDataType.Numeric),
        new JdeField("SBAPYN", "SBAPYN", JdeDataType.Numeric),
        new JdeField("SBAND01", "SBAND01", JdeDataType.Numeric),
        new JdeField("SBAND02", "SBAND02", JdeDataType.Numeric),
        new JdeField("SBAND03", "SBAND03", JdeDataType.Numeric),
        new JdeField("SBAND04", "SBAND04", JdeDataType.Numeric),
        new JdeField("SBAND05", "SBAND05", JdeDataType.Numeric),
        new JdeField("SBAND06", "SBAND06", JdeDataType.Numeric),
        new JdeField("SBAND07", "SBAND07", JdeDataType.Numeric),
        new JdeField("SBAND08", "SBAND08", JdeDataType.Numeric),
        new JdeField("SBAND09", "SBAND09", JdeDataType.Numeric),
        new JdeField("SBAND10", "SBAND10", JdeDataType.Numeric),
        new JdeField("SBAND11", "SBAND11", JdeDataType.Numeric),
        new JdeField("SBAND12", "SBAND12", JdeDataType.Numeric),
        new JdeField("SBAND13", "SBAND13", JdeDataType.Numeric),
        new JdeField("SBAND14", "SBAND14", JdeDataType.Numeric),
        new JdeField("SBWEA1", "SBWEA1", JdeDataType.Numeric),
        new JdeField("SBC75INID", "SBC75INID", JdeDataType.Numeric, null, true, true),
        new JdeField("SBFUTMATH1", "SBFUTMATH1", JdeDataType.Numeric),
        new JdeField("SBFUTSTR1", "SBFUTSTR1", JdeDataType.String, 100),
        new JdeField("SBFUTDATE1", "SBFUTDATE1", JdeDataType.Numeric),
        new JdeField("SBFUTUO1", "SBFUTUO1", JdeDataType.String, 2),
        new JdeField("SBUSER", "SBUSER", JdeDataType.String, 20),
        new JdeField("SBPID", "SBPID", JdeDataType.String, 20),
        new JdeField("SBJOBN", "SBJOBN", JdeDataType.String, 20),
        new JdeField("SBUPMJ", "SBUPMJ", JdeDataType.Numeric),
        new JdeField("SBUPMT", "SBUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75C902_0", "Primary Key on SBAID, SBC75INID, SBCTRY, SBFY, SBLT, SBSBLT, SBSBL, SBCRCD", new[] { "SBAID", "SBC75INID", "SBCTRY", "SBFY", "SBLT", "SBSBLT", "SBSBL", "SBCRCD" }, isUnique: true, isPrimaryKey: true)
    };
}
