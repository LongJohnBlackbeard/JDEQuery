using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F44H601 - .
/// </summary>
public class F44H601 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BHKCOO.
        /// </summary>
        public const string BHKCOO = "BHKCOO";

        /// <summary>
        /// BHDOCO.
        /// </summary>
        public const string BHDOCO = "BHDOCO";

        /// <summary>
        /// BHDCTO.
        /// </summary>
        public const string BHDCTO = "BHDCTO";

        /// <summary>
        /// BHSFXO.
        /// </summary>
        public const string BHSFXO = "BHSFXO";

        /// <summary>
        /// BHHBAREA.
        /// </summary>
        public const string BHHBAREA = "BHHBAREA";

        /// <summary>
        /// BHMCU.
        /// </summary>
        public const string BHMCU = "BHMCU";

        /// <summary>
        /// BHR001.
        /// </summary>
        public const string BHR001 = "BHR001";

        /// <summary>
        /// BHBIDTYPE.
        /// </summary>
        public const string BHBIDTYPE = "BHBIDTYPE";

        /// <summary>
        /// BHBUDONLY.
        /// </summary>
        public const string BHBUDONLY = "BHBUDONLY";

        /// <summary>
        /// BHVNDAOVR.
        /// </summary>
        public const string BHVNDAOVR = "BHVNDAOVR";

        /// <summary>
        /// BHUNIDOC.
        /// </summary>
        public const string BHUNIDOC = "BHUNIDOC";

        /// <summary>
        /// BHVNDTBD.
        /// </summary>
        public const string BHVNDTBD = "BHVNDTBD";

        /// <summary>
        /// BHAVEL.
        /// </summary>
        public const string BHAVEL = "BHAVEL";

        /// <summary>
        /// BHDESC.
        /// </summary>
        public const string BHDESC = "BHDESC";

        /// <summary>
        /// BHAN8.
        /// </summary>
        public const string BHAN8 = "BHAN8";

        /// <summary>
        /// BHSHAN.
        /// </summary>
        public const string BHSHAN = "BHSHAN";

        /// <summary>
        /// BHRMK.
        /// </summary>
        public const string BHRMK = "BHRMK";

        /// <summary>
        /// BHANBY.
        /// </summary>
        public const string BHANBY = "BHANBY";

        /// <summary>
        /// BHDGL.
        /// </summary>
        public const string BHDGL = "BHDGL";

        /// <summary>
        /// BHPEFJ.
        /// </summary>
        public const string BHPEFJ = "BHPEFJ";

        /// <summary>
        /// BHCNDJ.
        /// </summary>
        public const string BHCNDJ = "BHCNDJ";

        /// <summary>
        /// BHDRQJ.
        /// </summary>
        public const string BHDRQJ = "BHDRQJ";

        /// <summary>
        /// BHTRDJ.
        /// </summary>
        public const string BHTRDJ = "BHTRDJ";

        /// <summary>
        /// BHPDDJ.
        /// </summary>
        public const string BHPDDJ = "BHPDDJ";

        /// <summary>
        /// BHOPDJ.
        /// </summary>
        public const string BHOPDJ = "BHOPDJ";

        /// <summary>
        /// BHADDJ.
        /// </summary>
        public const string BHADDJ = "BHADDJ";

        /// <summary>
        /// BHPPDJ.
        /// </summary>
        public const string BHPPDJ = "BHPPDJ";

        /// <summary>
        /// BHPSDJ.
        /// </summary>
        public const string BHPSDJ = "BHPSDJ";

        /// <summary>
        /// BHPDP1.
        /// </summary>
        public const string BHPDP1 = "BHPDP1";

        /// <summary>
        /// BHPDP2.
        /// </summary>
        public const string BHPDP2 = "BHPDP2";

        /// <summary>
        /// BHPDP3.
        /// </summary>
        public const string BHPDP3 = "BHPDP3";

        /// <summary>
        /// BHPDP4.
        /// </summary>
        public const string BHPDP4 = "BHPDP4";

        /// <summary>
        /// BHPDP5.
        /// </summary>
        public const string BHPDP5 = "BHPDP5";

        /// <summary>
        /// BHFUF1.
        /// </summary>
        public const string BHFUF1 = "BHFUF1";

        /// <summary>
        /// BHPTC.
        /// </summary>
        public const string BHPTC = "BHPTC";

        /// <summary>
        /// BHTXA1.
        /// </summary>
        public const string BHTXA1 = "BHTXA1";

        /// <summary>
        /// BHEXR1.
        /// </summary>
        public const string BHEXR1 = "BHEXR1";

        /// <summary>
        /// BHPCRT.
        /// </summary>
        public const string BHPCRT = "BHPCRT";

        /// <summary>
        /// BHRTNR.
        /// </summary>
        public const string BHRTNR = "BHRTNR";

        /// <summary>
        /// BHOSTS.
        /// </summary>
        public const string BHOSTS = "BHOSTS";

        /// <summary>
        /// BHCRRM.
        /// </summary>
        public const string BHCRRM = "BHCRRM";

        /// <summary>
        /// BHCRCD.
        /// </summary>
        public const string BHCRCD = "BHCRCD";

        /// <summary>
        /// BHCRR.
        /// </summary>
        public const string BHCRR = "BHCRR";

        /// <summary>
        /// BHHBST1.
        /// </summary>
        public const string BHHBST1 = "BHHBST1";

        /// <summary>
        /// BHHBST2.
        /// </summary>
        public const string BHHBST2 = "BHHBST2";

        /// <summary>
        /// BHHBST3.
        /// </summary>
        public const string BHHBST3 = "BHHBST3";

        /// <summary>
        /// BHHBST4.
        /// </summary>
        public const string BHHBST4 = "BHHBST4";

        /// <summary>
        /// BHHBST5.
        /// </summary>
        public const string BHHBST5 = "BHHBST5";

        /// <summary>
        /// BHCRTU.
        /// </summary>
        public const string BHCRTU = "BHCRTU";

        /// <summary>
        /// BHCRTJ.
        /// </summary>
        public const string BHCRTJ = "BHCRTJ";

        /// <summary>
        /// BHCRTT.
        /// </summary>
        public const string BHCRTT = "BHCRTT";

        /// <summary>
        /// BHWRKSTNID.
        /// </summary>
        public const string BHWRKSTNID = "BHWRKSTNID";

        /// <summary>
        /// BHHBOPID.
        /// </summary>
        public const string BHHBOPID = "BHHBOPID";

        /// <summary>
        /// BHUPMB.
        /// </summary>
        public const string BHUPMB = "BHUPMB";

        /// <summary>
        /// BHUPMJ.
        /// </summary>
        public const string BHUPMJ = "BHUPMJ";

        /// <summary>
        /// BHUPMT.
        /// </summary>
        public const string BHUPMT = "BHUPMT";

        /// <summary>
        /// BHJOBN.
        /// </summary>
        public const string BHJOBN = "BHJOBN";

        /// <summary>
        /// BHPID.
        /// </summary>
        public const string BHPID = "BHPID";
    }

    /// <inheritdoc />
    public override string TableName => "F44H601";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BHKCOO", "BHKCOO", JdeDataType.String, 10, true, true),
        new JdeField("BHDOCO", "BHDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("BHDCTO", "BHDCTO", JdeDataType.String, 4, true, true),
        new JdeField("BHSFXO", "BHSFXO", JdeDataType.String, 6),
        new JdeField("BHHBAREA", "BHHBAREA", JdeDataType.String, 6),
        new JdeField("BHMCU", "BHMCU", JdeDataType.String, 24),
        new JdeField("BHR001", "BHR001", JdeDataType.String, 6),
        new JdeField("BHBIDTYPE", "BHBIDTYPE", JdeDataType.String, 4),
        new JdeField("BHBUDONLY", "BHBUDONLY", JdeDataType.String, 2),
        new JdeField("BHVNDAOVR", "BHVNDAOVR", JdeDataType.String, 2),
        new JdeField("BHUNIDOC", "BHUNIDOC", JdeDataType.String, 2),
        new JdeField("BHVNDTBD", "BHVNDTBD", JdeDataType.String, 2),
        new JdeField("BHAVEL", "BHAVEL", JdeDataType.String, 2),
        new JdeField("BHDESC", "BHDESC", JdeDataType.String, 60),
        new JdeField("BHAN8", "BHAN8", JdeDataType.Numeric),
        new JdeField("BHSHAN", "BHSHAN", JdeDataType.Numeric),
        new JdeField("BHRMK", "BHRMK", JdeDataType.String, 60),
        new JdeField("BHANBY", "BHANBY", JdeDataType.Numeric),
        new JdeField("BHDGL", "BHDGL", JdeDataType.Numeric),
        new JdeField("BHPEFJ", "BHPEFJ", JdeDataType.Numeric),
        new JdeField("BHCNDJ", "BHCNDJ", JdeDataType.Numeric),
        new JdeField("BHDRQJ", "BHDRQJ", JdeDataType.Numeric),
        new JdeField("BHTRDJ", "BHTRDJ", JdeDataType.Numeric),
        new JdeField("BHPDDJ", "BHPDDJ", JdeDataType.Numeric),
        new JdeField("BHOPDJ", "BHOPDJ", JdeDataType.Numeric),
        new JdeField("BHADDJ", "BHADDJ", JdeDataType.Numeric),
        new JdeField("BHPPDJ", "BHPPDJ", JdeDataType.Numeric),
        new JdeField("BHPSDJ", "BHPSDJ", JdeDataType.Numeric),
        new JdeField("BHPDP1", "BHPDP1", JdeDataType.String, 6),
        new JdeField("BHPDP2", "BHPDP2", JdeDataType.String, 6),
        new JdeField("BHPDP3", "BHPDP3", JdeDataType.String, 6),
        new JdeField("BHPDP4", "BHPDP4", JdeDataType.String, 6),
        new JdeField("BHPDP5", "BHPDP5", JdeDataType.String, 6),
        new JdeField("BHFUF1", "BHFUF1", JdeDataType.String, 2),
        new JdeField("BHPTC", "BHPTC", JdeDataType.String, 6),
        new JdeField("BHTXA1", "BHTXA1", JdeDataType.String, 20),
        new JdeField("BHEXR1", "BHEXR1", JdeDataType.String, 4),
        new JdeField("BHPCRT", "BHPCRT", JdeDataType.Numeric),
        new JdeField("BHRTNR", "BHRTNR", JdeDataType.String, 6),
        new JdeField("BHOSTS", "BHOSTS", JdeDataType.String, 2),
        new JdeField("BHCRRM", "BHCRRM", JdeDataType.String, 2),
        new JdeField("BHCRCD", "BHCRCD", JdeDataType.String, 6),
        new JdeField("BHCRR", "BHCRR", JdeDataType.Numeric),
        new JdeField("BHHBST1", "BHHBST1", JdeDataType.String, 2),
        new JdeField("BHHBST2", "BHHBST2", JdeDataType.String, 2),
        new JdeField("BHHBST3", "BHHBST3", JdeDataType.String, 2),
        new JdeField("BHHBST4", "BHHBST4", JdeDataType.String, 2),
        new JdeField("BHHBST5", "BHHBST5", JdeDataType.String, 2),
        new JdeField("BHCRTU", "BHCRTU", JdeDataType.String, 20),
        new JdeField("BHCRTJ", "BHCRTJ", JdeDataType.Numeric),
        new JdeField("BHCRTT", "BHCRTT", JdeDataType.Numeric),
        new JdeField("BHWRKSTNID", "BHWRKSTNID", JdeDataType.String, 20),
        new JdeField("BHHBOPID", "BHHBOPID", JdeDataType.String, 20),
        new JdeField("BHUPMB", "BHUPMB", JdeDataType.String, 20),
        new JdeField("BHUPMJ", "BHUPMJ", JdeDataType.Numeric),
        new JdeField("BHUPMT", "BHUPMT", JdeDataType.Numeric),
        new JdeField("BHJOBN", "BHJOBN", JdeDataType.String, 20),
        new JdeField("BHPID", "BHPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F44H601_0", "Primary Key on BHKCOO, BHDOCO, BHDCTO", new[] { "BHKCOO", "BHDOCO", "BHDCTO" }, isUnique: true, isPrimaryKey: true)
    };
}
