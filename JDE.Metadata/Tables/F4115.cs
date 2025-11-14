using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4115 - .
/// </summary>
public class F4115 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IHITM.
        /// </summary>
        public const string IHITM = "IHITM";

        /// <summary>
        /// IHMCU.
        /// </summary>
        public const string IHMCU = "IHMCU";

        /// <summary>
        /// IHCTRY.
        /// </summary>
        public const string IHCTRY = "IHCTRY";

        /// <summary>
        /// IHFY.
        /// </summary>
        public const string IHFY = "IHFY";

        /// <summary>
        /// IHFQ.
        /// </summary>
        public const string IHFQ = "IHFQ";

        /// <summary>
        /// IHLT.
        /// </summary>
        public const string IHLT = "IHLT";

        /// <summary>
        /// IHCMS.
        /// </summary>
        public const string IHCMS = "IHCMS";

        /// <summary>
        /// IHCMC.
        /// </summary>
        public const string IHCMC = "IHCMC";

        /// <summary>
        /// IHCYS.
        /// </summary>
        public const string IHCYS = "IHCYS";

        /// <summary>
        /// IHCYC.
        /// </summary>
        public const string IHCYC = "IHCYC";

        /// <summary>
        /// IHPYES.
        /// </summary>
        public const string IHPYES = "IHPYES";

        /// <summary>
        /// IHPYEC.
        /// </summary>
        public const string IHPYEC = "IHPYEC";

        /// <summary>
        /// IHSQ01.
        /// </summary>
        public const string IHSQ01 = "IHSQ01";

        /// <summary>
        /// IHSQ02.
        /// </summary>
        public const string IHSQ02 = "IHSQ02";

        /// <summary>
        /// IHSQ03.
        /// </summary>
        public const string IHSQ03 = "IHSQ03";

        /// <summary>
        /// IHSQ04.
        /// </summary>
        public const string IHSQ04 = "IHSQ04";

        /// <summary>
        /// IHSQ05.
        /// </summary>
        public const string IHSQ05 = "IHSQ05";

        /// <summary>
        /// IHSQ06.
        /// </summary>
        public const string IHSQ06 = "IHSQ06";

        /// <summary>
        /// IHSQ07.
        /// </summary>
        public const string IHSQ07 = "IHSQ07";

        /// <summary>
        /// IHSQ08.
        /// </summary>
        public const string IHSQ08 = "IHSQ08";

        /// <summary>
        /// IHSQ09.
        /// </summary>
        public const string IHSQ09 = "IHSQ09";

        /// <summary>
        /// IHSQ10.
        /// </summary>
        public const string IHSQ10 = "IHSQ10";

        /// <summary>
        /// IHSQ11.
        /// </summary>
        public const string IHSQ11 = "IHSQ11";

        /// <summary>
        /// IHSQ12.
        /// </summary>
        public const string IHSQ12 = "IHSQ12";

        /// <summary>
        /// IHSQ13.
        /// </summary>
        public const string IHSQ13 = "IHSQ13";

        /// <summary>
        /// IHSQ14.
        /// </summary>
        public const string IHSQ14 = "IHSQ14";

        /// <summary>
        /// IHDLIJ.
        /// </summary>
        public const string IHDLIJ = "IHDLIJ";

        /// <summary>
        /// IHLRCJ.
        /// </summary>
        public const string IHLRCJ = "IHLRCJ";

        /// <summary>
        /// IHLDAY.
        /// </summary>
        public const string IHLDAY = "IHLDAY";

        /// <summary>
        /// IHAS01.
        /// </summary>
        public const string IHAS01 = "IHAS01";

        /// <summary>
        /// IHAS02.
        /// </summary>
        public const string IHAS02 = "IHAS02";

        /// <summary>
        /// IHAS03.
        /// </summary>
        public const string IHAS03 = "IHAS03";

        /// <summary>
        /// IHAS04.
        /// </summary>
        public const string IHAS04 = "IHAS04";

        /// <summary>
        /// IHAS05.
        /// </summary>
        public const string IHAS05 = "IHAS05";

        /// <summary>
        /// IHAS06.
        /// </summary>
        public const string IHAS06 = "IHAS06";

        /// <summary>
        /// IHAS07.
        /// </summary>
        public const string IHAS07 = "IHAS07";

        /// <summary>
        /// IHAS08.
        /// </summary>
        public const string IHAS08 = "IHAS08";

        /// <summary>
        /// IHAS09.
        /// </summary>
        public const string IHAS09 = "IHAS09";

        /// <summary>
        /// IHAS10.
        /// </summary>
        public const string IHAS10 = "IHAS10";

        /// <summary>
        /// IHAS11.
        /// </summary>
        public const string IHAS11 = "IHAS11";

        /// <summary>
        /// IHAS12.
        /// </summary>
        public const string IHAS12 = "IHAS12";

        /// <summary>
        /// IHAS13.
        /// </summary>
        public const string IHAS13 = "IHAS13";

        /// <summary>
        /// IHAS14.
        /// </summary>
        public const string IHAS14 = "IHAS14";

        /// <summary>
        /// IHCI01.
        /// </summary>
        public const string IHCI01 = "IHCI01";

        /// <summary>
        /// IHCI02.
        /// </summary>
        public const string IHCI02 = "IHCI02";

        /// <summary>
        /// IHCI03.
        /// </summary>
        public const string IHCI03 = "IHCI03";

        /// <summary>
        /// IHCI04.
        /// </summary>
        public const string IHCI04 = "IHCI04";

        /// <summary>
        /// IHCI05.
        /// </summary>
        public const string IHCI05 = "IHCI05";

        /// <summary>
        /// IHCI06.
        /// </summary>
        public const string IHCI06 = "IHCI06";

        /// <summary>
        /// IHCI07.
        /// </summary>
        public const string IHCI07 = "IHCI07";

        /// <summary>
        /// IHCI08.
        /// </summary>
        public const string IHCI08 = "IHCI08";

        /// <summary>
        /// IHCI09.
        /// </summary>
        public const string IHCI09 = "IHCI09";

        /// <summary>
        /// IHCI10.
        /// </summary>
        public const string IHCI10 = "IHCI10";

        /// <summary>
        /// IHCI11.
        /// </summary>
        public const string IHCI11 = "IHCI11";

        /// <summary>
        /// IHCI12.
        /// </summary>
        public const string IHCI12 = "IHCI12";

        /// <summary>
        /// IHCI13.
        /// </summary>
        public const string IHCI13 = "IHCI13";

        /// <summary>
        /// IHCI14.
        /// </summary>
        public const string IHCI14 = "IHCI14";

        /// <summary>
        /// IHMA01.
        /// </summary>
        public const string IHMA01 = "IHMA01";

        /// <summary>
        /// IHMA02.
        /// </summary>
        public const string IHMA02 = "IHMA02";

        /// <summary>
        /// IHMA03.
        /// </summary>
        public const string IHMA03 = "IHMA03";

        /// <summary>
        /// IHMA04.
        /// </summary>
        public const string IHMA04 = "IHMA04";

        /// <summary>
        /// IHMA05.
        /// </summary>
        public const string IHMA05 = "IHMA05";

        /// <summary>
        /// IHMA06.
        /// </summary>
        public const string IHMA06 = "IHMA06";

        /// <summary>
        /// IHMA07.
        /// </summary>
        public const string IHMA07 = "IHMA07";

        /// <summary>
        /// IHMA08.
        /// </summary>
        public const string IHMA08 = "IHMA08";

        /// <summary>
        /// IHMA09.
        /// </summary>
        public const string IHMA09 = "IHMA09";

        /// <summary>
        /// IHMA10.
        /// </summary>
        public const string IHMA10 = "IHMA10";

        /// <summary>
        /// IHMA11.
        /// </summary>
        public const string IHMA11 = "IHMA11";

        /// <summary>
        /// IHMA12.
        /// </summary>
        public const string IHMA12 = "IHMA12";

        /// <summary>
        /// IHMA13.
        /// </summary>
        public const string IHMA13 = "IHMA13";

        /// <summary>
        /// IHMA14.
        /// </summary>
        public const string IHMA14 = "IHMA14";

        /// <summary>
        /// IHAV01.
        /// </summary>
        public const string IHAV01 = "IHAV01";

        /// <summary>
        /// IHAV02.
        /// </summary>
        public const string IHAV02 = "IHAV02";

        /// <summary>
        /// IHAV03.
        /// </summary>
        public const string IHAV03 = "IHAV03";

        /// <summary>
        /// IHAV04.
        /// </summary>
        public const string IHAV04 = "IHAV04";

        /// <summary>
        /// IHAV05.
        /// </summary>
        public const string IHAV05 = "IHAV05";

        /// <summary>
        /// IHAV06.
        /// </summary>
        public const string IHAV06 = "IHAV06";

        /// <summary>
        /// IHAV07.
        /// </summary>
        public const string IHAV07 = "IHAV07";

        /// <summary>
        /// IHAV08.
        /// </summary>
        public const string IHAV08 = "IHAV08";

        /// <summary>
        /// IHAV09.
        /// </summary>
        public const string IHAV09 = "IHAV09";

        /// <summary>
        /// IHAV10.
        /// </summary>
        public const string IHAV10 = "IHAV10";

        /// <summary>
        /// IHAV11.
        /// </summary>
        public const string IHAV11 = "IHAV11";

        /// <summary>
        /// IHAV12.
        /// </summary>
        public const string IHAV12 = "IHAV12";

        /// <summary>
        /// IHAV13.
        /// </summary>
        public const string IHAV13 = "IHAV13";

        /// <summary>
        /// IHAV14.
        /// </summary>
        public const string IHAV14 = "IHAV14";

        /// <summary>
        /// IHPQ01.
        /// </summary>
        public const string IHPQ01 = "IHPQ01";

        /// <summary>
        /// IHPQ02.
        /// </summary>
        public const string IHPQ02 = "IHPQ02";

        /// <summary>
        /// IHPQ03.
        /// </summary>
        public const string IHPQ03 = "IHPQ03";

        /// <summary>
        /// IHPQ04.
        /// </summary>
        public const string IHPQ04 = "IHPQ04";

        /// <summary>
        /// IHPQ05.
        /// </summary>
        public const string IHPQ05 = "IHPQ05";

        /// <summary>
        /// IHPQ06.
        /// </summary>
        public const string IHPQ06 = "IHPQ06";

        /// <summary>
        /// IHPQ07.
        /// </summary>
        public const string IHPQ07 = "IHPQ07";

        /// <summary>
        /// IHPQ08.
        /// </summary>
        public const string IHPQ08 = "IHPQ08";

        /// <summary>
        /// IHPQ09.
        /// </summary>
        public const string IHPQ09 = "IHPQ09";

        /// <summary>
        /// IHPQ10.
        /// </summary>
        public const string IHPQ10 = "IHPQ10";

        /// <summary>
        /// IHPQ11.
        /// </summary>
        public const string IHPQ11 = "IHPQ11";

        /// <summary>
        /// IHPQ12.
        /// </summary>
        public const string IHPQ12 = "IHPQ12";

        /// <summary>
        /// IHPQ13.
        /// </summary>
        public const string IHPQ13 = "IHPQ13";

        /// <summary>
        /// IHPQ14.
        /// </summary>
        public const string IHPQ14 = "IHPQ14";

        /// <summary>
        /// IHAE01.
        /// </summary>
        public const string IHAE01 = "IHAE01";

        /// <summary>
        /// IHAE02.
        /// </summary>
        public const string IHAE02 = "IHAE02";

        /// <summary>
        /// IHAE03.
        /// </summary>
        public const string IHAE03 = "IHAE03";

        /// <summary>
        /// IHAE04.
        /// </summary>
        public const string IHAE04 = "IHAE04";

        /// <summary>
        /// IHAE05.
        /// </summary>
        public const string IHAE05 = "IHAE05";

        /// <summary>
        /// IHAE06.
        /// </summary>
        public const string IHAE06 = "IHAE06";

        /// <summary>
        /// IHAE07.
        /// </summary>
        public const string IHAE07 = "IHAE07";

        /// <summary>
        /// IHAE08.
        /// </summary>
        public const string IHAE08 = "IHAE08";

        /// <summary>
        /// IHAE09.
        /// </summary>
        public const string IHAE09 = "IHAE09";

        /// <summary>
        /// IHAE10.
        /// </summary>
        public const string IHAE10 = "IHAE10";

        /// <summary>
        /// IHAE11.
        /// </summary>
        public const string IHAE11 = "IHAE11";

        /// <summary>
        /// IHAE12.
        /// </summary>
        public const string IHAE12 = "IHAE12";

        /// <summary>
        /// IHAE13.
        /// </summary>
        public const string IHAE13 = "IHAE13";

        /// <summary>
        /// IHAE14.
        /// </summary>
        public const string IHAE14 = "IHAE14";

        /// <summary>
        /// IHCW01.
        /// </summary>
        public const string IHCW01 = "IHCW01";

        /// <summary>
        /// IHCW02.
        /// </summary>
        public const string IHCW02 = "IHCW02";

        /// <summary>
        /// IHCW03.
        /// </summary>
        public const string IHCW03 = "IHCW03";

        /// <summary>
        /// IHCW04.
        /// </summary>
        public const string IHCW04 = "IHCW04";

        /// <summary>
        /// IHCW05.
        /// </summary>
        public const string IHCW05 = "IHCW05";

        /// <summary>
        /// IHCW06.
        /// </summary>
        public const string IHCW06 = "IHCW06";

        /// <summary>
        /// IHCW07.
        /// </summary>
        public const string IHCW07 = "IHCW07";

        /// <summary>
        /// IHCW08.
        /// </summary>
        public const string IHCW08 = "IHCW08";

        /// <summary>
        /// IHCW09.
        /// </summary>
        public const string IHCW09 = "IHCW09";

        /// <summary>
        /// IHCW10.
        /// </summary>
        public const string IHCW10 = "IHCW10";

        /// <summary>
        /// IHCW11.
        /// </summary>
        public const string IHCW11 = "IHCW11";

        /// <summary>
        /// IHCW12.
        /// </summary>
        public const string IHCW12 = "IHCW12";

        /// <summary>
        /// IHCW13.
        /// </summary>
        public const string IHCW13 = "IHCW13";

        /// <summary>
        /// IHCW14.
        /// </summary>
        public const string IHCW14 = "IHCW14";

        /// <summary>
        /// IHSM01.
        /// </summary>
        public const string IHSM01 = "IHSM01";

        /// <summary>
        /// IHSM02.
        /// </summary>
        public const string IHSM02 = "IHSM02";

        /// <summary>
        /// IHSM03.
        /// </summary>
        public const string IHSM03 = "IHSM03";

        /// <summary>
        /// IHSM04.
        /// </summary>
        public const string IHSM04 = "IHSM04";

        /// <summary>
        /// IHSM05.
        /// </summary>
        public const string IHSM05 = "IHSM05";

        /// <summary>
        /// IHSM06.
        /// </summary>
        public const string IHSM06 = "IHSM06";

        /// <summary>
        /// IHSM07.
        /// </summary>
        public const string IHSM07 = "IHSM07";

        /// <summary>
        /// IHSM08.
        /// </summary>
        public const string IHSM08 = "IHSM08";

        /// <summary>
        /// IHSM09.
        /// </summary>
        public const string IHSM09 = "IHSM09";

        /// <summary>
        /// IHSM10.
        /// </summary>
        public const string IHSM10 = "IHSM10";

        /// <summary>
        /// IHSM11.
        /// </summary>
        public const string IHSM11 = "IHSM11";

        /// <summary>
        /// IHSM12.
        /// </summary>
        public const string IHSM12 = "IHSM12";

        /// <summary>
        /// IHSM13.
        /// </summary>
        public const string IHSM13 = "IHSM13";

        /// <summary>
        /// IHSM14.
        /// </summary>
        public const string IHSM14 = "IHSM14";

        /// <summary>
        /// IHC101.
        /// </summary>
        public const string IHC101 = "IHC101";

        /// <summary>
        /// IHC102.
        /// </summary>
        public const string IHC102 = "IHC102";

        /// <summary>
        /// IHC103.
        /// </summary>
        public const string IHC103 = "IHC103";

        /// <summary>
        /// IHC104.
        /// </summary>
        public const string IHC104 = "IHC104";

        /// <summary>
        /// IHC105.
        /// </summary>
        public const string IHC105 = "IHC105";

        /// <summary>
        /// IHC106.
        /// </summary>
        public const string IHC106 = "IHC106";

        /// <summary>
        /// IHC107.
        /// </summary>
        public const string IHC107 = "IHC107";

        /// <summary>
        /// IHC108.
        /// </summary>
        public const string IHC108 = "IHC108";

        /// <summary>
        /// IHC109.
        /// </summary>
        public const string IHC109 = "IHC109";

        /// <summary>
        /// IHC110.
        /// </summary>
        public const string IHC110 = "IHC110";

        /// <summary>
        /// IHC111.
        /// </summary>
        public const string IHC111 = "IHC111";

        /// <summary>
        /// IHC112.
        /// </summary>
        public const string IHC112 = "IHC112";

        /// <summary>
        /// IHC113.
        /// </summary>
        public const string IHC113 = "IHC113";

        /// <summary>
        /// IHC114.
        /// </summary>
        public const string IHC114 = "IHC114";

        /// <summary>
        /// IHC201.
        /// </summary>
        public const string IHC201 = "IHC201";

        /// <summary>
        /// IHC202.
        /// </summary>
        public const string IHC202 = "IHC202";

        /// <summary>
        /// IHC203.
        /// </summary>
        public const string IHC203 = "IHC203";

        /// <summary>
        /// IHC204.
        /// </summary>
        public const string IHC204 = "IHC204";

        /// <summary>
        /// IHC205.
        /// </summary>
        public const string IHC205 = "IHC205";

        /// <summary>
        /// IHC206.
        /// </summary>
        public const string IHC206 = "IHC206";

        /// <summary>
        /// IHC207.
        /// </summary>
        public const string IHC207 = "IHC207";

        /// <summary>
        /// IHC208.
        /// </summary>
        public const string IHC208 = "IHC208";

        /// <summary>
        /// IHC209.
        /// </summary>
        public const string IHC209 = "IHC209";

        /// <summary>
        /// IHC210.
        /// </summary>
        public const string IHC210 = "IHC210";

        /// <summary>
        /// IHC211.
        /// </summary>
        public const string IHC211 = "IHC211";

        /// <summary>
        /// IHC212.
        /// </summary>
        public const string IHC212 = "IHC212";

        /// <summary>
        /// IHC213.
        /// </summary>
        public const string IHC213 = "IHC213";

        /// <summary>
        /// IHC214.
        /// </summary>
        public const string IHC214 = "IHC214";

        /// <summary>
        /// IHC301.
        /// </summary>
        public const string IHC301 = "IHC301";

        /// <summary>
        /// IHC302.
        /// </summary>
        public const string IHC302 = "IHC302";

        /// <summary>
        /// IHC303.
        /// </summary>
        public const string IHC303 = "IHC303";

        /// <summary>
        /// IHC304.
        /// </summary>
        public const string IHC304 = "IHC304";

        /// <summary>
        /// IHC305.
        /// </summary>
        public const string IHC305 = "IHC305";

        /// <summary>
        /// IHC306.
        /// </summary>
        public const string IHC306 = "IHC306";

        /// <summary>
        /// IHC307.
        /// </summary>
        public const string IHC307 = "IHC307";

        /// <summary>
        /// IHC308.
        /// </summary>
        public const string IHC308 = "IHC308";

        /// <summary>
        /// IHC309.
        /// </summary>
        public const string IHC309 = "IHC309";

        /// <summary>
        /// IHC310.
        /// </summary>
        public const string IHC310 = "IHC310";

        /// <summary>
        /// IHC311.
        /// </summary>
        public const string IHC311 = "IHC311";

        /// <summary>
        /// IHC312.
        /// </summary>
        public const string IHC312 = "IHC312";

        /// <summary>
        /// IHC313.
        /// </summary>
        public const string IHC313 = "IHC313";

        /// <summary>
        /// IHC314.
        /// </summary>
        public const string IHC314 = "IHC314";

        /// <summary>
        /// IHGMTD.
        /// </summary>
        public const string IHGMTD = "IHGMTD";

        /// <summary>
        /// IHINVV.
        /// </summary>
        public const string IHINVV = "IHINVV";
    }

    /// <inheritdoc />
    public override string TableName => "F4115";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IHITM", "IHITM", JdeDataType.Numeric, null, true, true),
        new JdeField("IHMCU", "IHMCU", JdeDataType.String, 24, true, true),
        new JdeField("IHCTRY", "IHCTRY", JdeDataType.Numeric),
        new JdeField("IHFY", "IHFY", JdeDataType.Numeric, null, true, true),
        new JdeField("IHFQ", "IHFQ", JdeDataType.String, 8),
        new JdeField("IHLT", "IHLT", JdeDataType.String, 4),
        new JdeField("IHCMS", "IHCMS", JdeDataType.Numeric),
        new JdeField("IHCMC", "IHCMC", JdeDataType.Numeric),
        new JdeField("IHCYS", "IHCYS", JdeDataType.Numeric),
        new JdeField("IHCYC", "IHCYC", JdeDataType.Numeric),
        new JdeField("IHPYES", "IHPYES", JdeDataType.Numeric),
        new JdeField("IHPYEC", "IHPYEC", JdeDataType.Numeric),
        new JdeField("IHSQ01", "IHSQ01", JdeDataType.Numeric),
        new JdeField("IHSQ02", "IHSQ02", JdeDataType.Numeric),
        new JdeField("IHSQ03", "IHSQ03", JdeDataType.Numeric),
        new JdeField("IHSQ04", "IHSQ04", JdeDataType.Numeric),
        new JdeField("IHSQ05", "IHSQ05", JdeDataType.Numeric),
        new JdeField("IHSQ06", "IHSQ06", JdeDataType.Numeric),
        new JdeField("IHSQ07", "IHSQ07", JdeDataType.Numeric),
        new JdeField("IHSQ08", "IHSQ08", JdeDataType.Numeric),
        new JdeField("IHSQ09", "IHSQ09", JdeDataType.Numeric),
        new JdeField("IHSQ10", "IHSQ10", JdeDataType.Numeric),
        new JdeField("IHSQ11", "IHSQ11", JdeDataType.Numeric),
        new JdeField("IHSQ12", "IHSQ12", JdeDataType.Numeric),
        new JdeField("IHSQ13", "IHSQ13", JdeDataType.Numeric),
        new JdeField("IHSQ14", "IHSQ14", JdeDataType.Numeric),
        new JdeField("IHDLIJ", "IHDLIJ", JdeDataType.Numeric),
        new JdeField("IHLRCJ", "IHLRCJ", JdeDataType.Numeric),
        new JdeField("IHLDAY", "IHLDAY", JdeDataType.Numeric),
        new JdeField("IHAS01", "IHAS01", JdeDataType.Numeric),
        new JdeField("IHAS02", "IHAS02", JdeDataType.Numeric),
        new JdeField("IHAS03", "IHAS03", JdeDataType.Numeric),
        new JdeField("IHAS04", "IHAS04", JdeDataType.Numeric),
        new JdeField("IHAS05", "IHAS05", JdeDataType.Numeric),
        new JdeField("IHAS06", "IHAS06", JdeDataType.Numeric),
        new JdeField("IHAS07", "IHAS07", JdeDataType.Numeric),
        new JdeField("IHAS08", "IHAS08", JdeDataType.Numeric),
        new JdeField("IHAS09", "IHAS09", JdeDataType.Numeric),
        new JdeField("IHAS10", "IHAS10", JdeDataType.Numeric),
        new JdeField("IHAS11", "IHAS11", JdeDataType.Numeric),
        new JdeField("IHAS12", "IHAS12", JdeDataType.Numeric),
        new JdeField("IHAS13", "IHAS13", JdeDataType.Numeric),
        new JdeField("IHAS14", "IHAS14", JdeDataType.Numeric),
        new JdeField("IHCI01", "IHCI01", JdeDataType.Numeric),
        new JdeField("IHCI02", "IHCI02", JdeDataType.Numeric),
        new JdeField("IHCI03", "IHCI03", JdeDataType.Numeric),
        new JdeField("IHCI04", "IHCI04", JdeDataType.Numeric),
        new JdeField("IHCI05", "IHCI05", JdeDataType.Numeric),
        new JdeField("IHCI06", "IHCI06", JdeDataType.Numeric),
        new JdeField("IHCI07", "IHCI07", JdeDataType.Numeric),
        new JdeField("IHCI08", "IHCI08", JdeDataType.Numeric),
        new JdeField("IHCI09", "IHCI09", JdeDataType.Numeric),
        new JdeField("IHCI10", "IHCI10", JdeDataType.Numeric),
        new JdeField("IHCI11", "IHCI11", JdeDataType.Numeric),
        new JdeField("IHCI12", "IHCI12", JdeDataType.Numeric),
        new JdeField("IHCI13", "IHCI13", JdeDataType.Numeric),
        new JdeField("IHCI14", "IHCI14", JdeDataType.Numeric),
        new JdeField("IHMA01", "IHMA01", JdeDataType.Numeric),
        new JdeField("IHMA02", "IHMA02", JdeDataType.Numeric),
        new JdeField("IHMA03", "IHMA03", JdeDataType.Numeric),
        new JdeField("IHMA04", "IHMA04", JdeDataType.Numeric),
        new JdeField("IHMA05", "IHMA05", JdeDataType.Numeric),
        new JdeField("IHMA06", "IHMA06", JdeDataType.Numeric),
        new JdeField("IHMA07", "IHMA07", JdeDataType.Numeric),
        new JdeField("IHMA08", "IHMA08", JdeDataType.Numeric),
        new JdeField("IHMA09", "IHMA09", JdeDataType.Numeric),
        new JdeField("IHMA10", "IHMA10", JdeDataType.Numeric),
        new JdeField("IHMA11", "IHMA11", JdeDataType.Numeric),
        new JdeField("IHMA12", "IHMA12", JdeDataType.Numeric),
        new JdeField("IHMA13", "IHMA13", JdeDataType.Numeric),
        new JdeField("IHMA14", "IHMA14", JdeDataType.Numeric),
        new JdeField("IHAV01", "IHAV01", JdeDataType.Numeric),
        new JdeField("IHAV02", "IHAV02", JdeDataType.Numeric),
        new JdeField("IHAV03", "IHAV03", JdeDataType.Numeric),
        new JdeField("IHAV04", "IHAV04", JdeDataType.Numeric),
        new JdeField("IHAV05", "IHAV05", JdeDataType.Numeric),
        new JdeField("IHAV06", "IHAV06", JdeDataType.Numeric),
        new JdeField("IHAV07", "IHAV07", JdeDataType.Numeric),
        new JdeField("IHAV08", "IHAV08", JdeDataType.Numeric),
        new JdeField("IHAV09", "IHAV09", JdeDataType.Numeric),
        new JdeField("IHAV10", "IHAV10", JdeDataType.Numeric),
        new JdeField("IHAV11", "IHAV11", JdeDataType.Numeric),
        new JdeField("IHAV12", "IHAV12", JdeDataType.Numeric),
        new JdeField("IHAV13", "IHAV13", JdeDataType.Numeric),
        new JdeField("IHAV14", "IHAV14", JdeDataType.Numeric),
        new JdeField("IHPQ01", "IHPQ01", JdeDataType.Numeric),
        new JdeField("IHPQ02", "IHPQ02", JdeDataType.Numeric),
        new JdeField("IHPQ03", "IHPQ03", JdeDataType.Numeric),
        new JdeField("IHPQ04", "IHPQ04", JdeDataType.Numeric),
        new JdeField("IHPQ05", "IHPQ05", JdeDataType.Numeric),
        new JdeField("IHPQ06", "IHPQ06", JdeDataType.Numeric),
        new JdeField("IHPQ07", "IHPQ07", JdeDataType.Numeric),
        new JdeField("IHPQ08", "IHPQ08", JdeDataType.Numeric),
        new JdeField("IHPQ09", "IHPQ09", JdeDataType.Numeric),
        new JdeField("IHPQ10", "IHPQ10", JdeDataType.Numeric),
        new JdeField("IHPQ11", "IHPQ11", JdeDataType.Numeric),
        new JdeField("IHPQ12", "IHPQ12", JdeDataType.Numeric),
        new JdeField("IHPQ13", "IHPQ13", JdeDataType.Numeric),
        new JdeField("IHPQ14", "IHPQ14", JdeDataType.Numeric),
        new JdeField("IHAE01", "IHAE01", JdeDataType.Numeric),
        new JdeField("IHAE02", "IHAE02", JdeDataType.Numeric),
        new JdeField("IHAE03", "IHAE03", JdeDataType.Numeric),
        new JdeField("IHAE04", "IHAE04", JdeDataType.Numeric),
        new JdeField("IHAE05", "IHAE05", JdeDataType.Numeric),
        new JdeField("IHAE06", "IHAE06", JdeDataType.Numeric),
        new JdeField("IHAE07", "IHAE07", JdeDataType.Numeric),
        new JdeField("IHAE08", "IHAE08", JdeDataType.Numeric),
        new JdeField("IHAE09", "IHAE09", JdeDataType.Numeric),
        new JdeField("IHAE10", "IHAE10", JdeDataType.Numeric),
        new JdeField("IHAE11", "IHAE11", JdeDataType.Numeric),
        new JdeField("IHAE12", "IHAE12", JdeDataType.Numeric),
        new JdeField("IHAE13", "IHAE13", JdeDataType.Numeric),
        new JdeField("IHAE14", "IHAE14", JdeDataType.Numeric),
        new JdeField("IHCW01", "IHCW01", JdeDataType.Numeric),
        new JdeField("IHCW02", "IHCW02", JdeDataType.Numeric),
        new JdeField("IHCW03", "IHCW03", JdeDataType.Numeric),
        new JdeField("IHCW04", "IHCW04", JdeDataType.Numeric),
        new JdeField("IHCW05", "IHCW05", JdeDataType.Numeric),
        new JdeField("IHCW06", "IHCW06", JdeDataType.Numeric),
        new JdeField("IHCW07", "IHCW07", JdeDataType.Numeric),
        new JdeField("IHCW08", "IHCW08", JdeDataType.Numeric),
        new JdeField("IHCW09", "IHCW09", JdeDataType.Numeric),
        new JdeField("IHCW10", "IHCW10", JdeDataType.Numeric),
        new JdeField("IHCW11", "IHCW11", JdeDataType.Numeric),
        new JdeField("IHCW12", "IHCW12", JdeDataType.Numeric),
        new JdeField("IHCW13", "IHCW13", JdeDataType.Numeric),
        new JdeField("IHCW14", "IHCW14", JdeDataType.Numeric),
        new JdeField("IHSM01", "IHSM01", JdeDataType.String, 2),
        new JdeField("IHSM02", "IHSM02", JdeDataType.String, 2),
        new JdeField("IHSM03", "IHSM03", JdeDataType.String, 2),
        new JdeField("IHSM04", "IHSM04", JdeDataType.String, 2),
        new JdeField("IHSM05", "IHSM05", JdeDataType.String, 2),
        new JdeField("IHSM06", "IHSM06", JdeDataType.String, 2),
        new JdeField("IHSM07", "IHSM07", JdeDataType.String, 2),
        new JdeField("IHSM08", "IHSM08", JdeDataType.String, 2),
        new JdeField("IHSM09", "IHSM09", JdeDataType.String, 2),
        new JdeField("IHSM10", "IHSM10", JdeDataType.String, 2),
        new JdeField("IHSM11", "IHSM11", JdeDataType.String, 2),
        new JdeField("IHSM12", "IHSM12", JdeDataType.String, 2),
        new JdeField("IHSM13", "IHSM13", JdeDataType.String, 2),
        new JdeField("IHSM14", "IHSM14", JdeDataType.String, 2),
        new JdeField("IHC101", "IHC101", JdeDataType.String, 2),
        new JdeField("IHC102", "IHC102", JdeDataType.String, 2),
        new JdeField("IHC103", "IHC103", JdeDataType.String, 2),
        new JdeField("IHC104", "IHC104", JdeDataType.String, 2),
        new JdeField("IHC105", "IHC105", JdeDataType.String, 2),
        new JdeField("IHC106", "IHC106", JdeDataType.String, 2),
        new JdeField("IHC107", "IHC107", JdeDataType.String, 2),
        new JdeField("IHC108", "IHC108", JdeDataType.String, 2),
        new JdeField("IHC109", "IHC109", JdeDataType.String, 2),
        new JdeField("IHC110", "IHC110", JdeDataType.String, 2),
        new JdeField("IHC111", "IHC111", JdeDataType.String, 2),
        new JdeField("IHC112", "IHC112", JdeDataType.String, 2),
        new JdeField("IHC113", "IHC113", JdeDataType.String, 2),
        new JdeField("IHC114", "IHC114", JdeDataType.String, 2),
        new JdeField("IHC201", "IHC201", JdeDataType.String, 2),
        new JdeField("IHC202", "IHC202", JdeDataType.String, 2),
        new JdeField("IHC203", "IHC203", JdeDataType.String, 2),
        new JdeField("IHC204", "IHC204", JdeDataType.String, 2),
        new JdeField("IHC205", "IHC205", JdeDataType.String, 2),
        new JdeField("IHC206", "IHC206", JdeDataType.String, 2),
        new JdeField("IHC207", "IHC207", JdeDataType.String, 2),
        new JdeField("IHC208", "IHC208", JdeDataType.String, 2),
        new JdeField("IHC209", "IHC209", JdeDataType.String, 2),
        new JdeField("IHC210", "IHC210", JdeDataType.String, 2),
        new JdeField("IHC211", "IHC211", JdeDataType.String, 2),
        new JdeField("IHC212", "IHC212", JdeDataType.String, 2),
        new JdeField("IHC213", "IHC213", JdeDataType.String, 2),
        new JdeField("IHC214", "IHC214", JdeDataType.String, 2),
        new JdeField("IHC301", "IHC301", JdeDataType.String, 2),
        new JdeField("IHC302", "IHC302", JdeDataType.String, 2),
        new JdeField("IHC303", "IHC303", JdeDataType.String, 2),
        new JdeField("IHC304", "IHC304", JdeDataType.String, 2),
        new JdeField("IHC305", "IHC305", JdeDataType.String, 2),
        new JdeField("IHC306", "IHC306", JdeDataType.String, 2),
        new JdeField("IHC307", "IHC307", JdeDataType.String, 2),
        new JdeField("IHC308", "IHC308", JdeDataType.String, 2),
        new JdeField("IHC309", "IHC309", JdeDataType.String, 2),
        new JdeField("IHC310", "IHC310", JdeDataType.String, 2),
        new JdeField("IHC311", "IHC311", JdeDataType.String, 2),
        new JdeField("IHC312", "IHC312", JdeDataType.String, 2),
        new JdeField("IHC313", "IHC313", JdeDataType.String, 2),
        new JdeField("IHC314", "IHC314", JdeDataType.String, 2),
        new JdeField("IHGMTD", "IHGMTD", JdeDataType.Numeric),
        new JdeField("IHINVV", "IHINVV", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4115_0", "Primary Key on IHITM, IHMCU, IHFY", new[] { "IHITM", "IHMCU", "IHFY" }, isUnique: true, isPrimaryKey: true)
    };
}
