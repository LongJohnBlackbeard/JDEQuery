using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I310Y - .
/// </summary>
public class F75I310Y : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Q2YEXU.
        /// </summary>
        public const string Q2YEXU = "Q2YEXU";

        /// <summary>
        /// Q2YRM.
        /// </summary>
        public const string Q2YRM = "Q2YRM";

        /// <summary>
        /// Q2MNTH.
        /// </summary>
        public const string Q2MNTH = "Q2MNTH";

        /// <summary>
        /// Q2YMCB.
        /// </summary>
        public const string Q2YMCB = "Q2YMCB";

        /// <summary>
        /// Q2YMCR.
        /// </summary>
        public const string Q2YMCR = "Q2YMCR";

        /// <summary>
        /// Q2YMDR.
        /// </summary>
        public const string Q2YMDR = "Q2YMDR";

        /// <summary>
        /// Q2YMOB.
        /// </summary>
        public const string Q2YMOB = "Q2YMOB";

        /// <summary>
        /// Q2YNXE.
        /// </summary>
        public const string Q2YNXE = "Q2YNXE";

        /// <summary>
        /// Q2YMBA.
        /// </summary>
        public const string Q2YMBA = "Q2YMBA";

        /// <summary>
        /// Q2YPCB.
        /// </summary>
        public const string Q2YPCB = "Q2YPCB";

        /// <summary>
        /// Q2YPCR.
        /// </summary>
        public const string Q2YPCR = "Q2YPCR";

        /// <summary>
        /// Q2YPDR.
        /// </summary>
        public const string Q2YPDR = "Q2YPDR";

        /// <summary>
        /// Q2YPOB.
        /// </summary>
        public const string Q2YPOB = "Q2YPOB";

        /// <summary>
        /// Q2YNXP.
        /// </summary>
        public const string Q2YNXP = "Q2YNXP";

        /// <summary>
        /// Q2YCCB.
        /// </summary>
        public const string Q2YCCB = "Q2YCCB";

        /// <summary>
        /// Q2YCCR.
        /// </summary>
        public const string Q2YCCR = "Q2YCCR";

        /// <summary>
        /// Q2YCDR.
        /// </summary>
        public const string Q2YCDR = "Q2YCDR";

        /// <summary>
        /// Q2YCOB.
        /// </summary>
        public const string Q2YCOB = "Q2YCOB";

        /// <summary>
        /// Q2YCXP.
        /// </summary>
        public const string Q2YCXP = "Q2YCXP";

        /// <summary>
        /// Q2YCBA.
        /// </summary>
        public const string Q2YCBA = "Q2YCBA";

        /// <summary>
        /// Q2YDCB.
        /// </summary>
        public const string Q2YDCB = "Q2YDCB";

        /// <summary>
        /// Q2YDCR.
        /// </summary>
        public const string Q2YDCR = "Q2YDCR";

        /// <summary>
        /// Q2YDDR.
        /// </summary>
        public const string Q2YDDR = "Q2YDDR";

        /// <summary>
        /// Q2YDOB.
        /// </summary>
        public const string Q2YDOB = "Q2YDOB";

        /// <summary>
        /// Q2YDXP.
        /// </summary>
        public const string Q2YDXP = "Q2YDXP";

        /// <summary>
        /// Q2YAR3N.
        /// </summary>
        public const string Q2YAR3N = "Q2YAR3N";

        /// <summary>
        /// Q2YARN.
        /// </summary>
        public const string Q2YARN = "Q2YARN";

        /// <summary>
        /// Q2YD3N.
        /// </summary>
        public const string Q2YD3N = "Q2YD3N";

        /// <summary>
        /// Q2YPLBEDOP.
        /// </summary>
        public const string Q2YPLBEDOP = "Q2YPLBEDOP";

        /// <summary>
        /// Q2YPLSEDOP.
        /// </summary>
        public const string Q2YPLSEDOP = "Q2YPLSEDOP";

        /// <summary>
        /// Q2YPLAEDOP.
        /// </summary>
        public const string Q2YPLAEDOP = "Q2YPLAEDOP";

        /// <summary>
        /// Q2YPLNCDOP.
        /// </summary>
        public const string Q2YPLNCDOP = "Q2YPLNCDOP";

        /// <summary>
        /// Q2YA2BEDOP.
        /// </summary>
        public const string Q2YA2BEDOP = "Q2YA2BEDOP";

        /// <summary>
        /// Q2YA2SEDOP.
        /// </summary>
        public const string Q2YA2SEDOP = "Q2YA2SEDOP";

        /// <summary>
        /// Q2YA2AEDOP.
        /// </summary>
        public const string Q2YA2AEDOP = "Q2YA2AEDOP";

        /// <summary>
        /// Q2YA2NCDOP.
        /// </summary>
        public const string Q2YA2NCDOP = "Q2YA2NCDOP";

        /// <summary>
        /// Q2YC2BEDOP.
        /// </summary>
        public const string Q2YC2BEDOP = "Q2YC2BEDOP";

        /// <summary>
        /// Q2YC2SEDOP.
        /// </summary>
        public const string Q2YC2SEDOP = "Q2YC2SEDOP";

        /// <summary>
        /// Q2YC2AEDOP.
        /// </summary>
        public const string Q2YC2AEDOP = "Q2YC2AEDOP";

        /// <summary>
        /// Q2YC2NCDOP.
        /// </summary>
        public const string Q2YC2NCDOP = "Q2YC2NCDOP";

        /// <summary>
        /// Q2YPLBEDDR.
        /// </summary>
        public const string Q2YPLBEDDR = "Q2YPLBEDDR";

        /// <summary>
        /// Q2YPLSEDDR.
        /// </summary>
        public const string Q2YPLSEDDR = "Q2YPLSEDDR";

        /// <summary>
        /// Q2YPLAEDDR.
        /// </summary>
        public const string Q2YPLAEDDR = "Q2YPLAEDDR";

        /// <summary>
        /// Q2YPLNCDDR.
        /// </summary>
        public const string Q2YPLNCDDR = "Q2YPLNCDDR";

        /// <summary>
        /// Q2YA2BEDDR.
        /// </summary>
        public const string Q2YA2BEDDR = "Q2YA2BEDDR";

        /// <summary>
        /// Q2YA2SEDDR.
        /// </summary>
        public const string Q2YA2SEDDR = "Q2YA2SEDDR";

        /// <summary>
        /// Q2YA2AEDDR.
        /// </summary>
        public const string Q2YA2AEDDR = "Q2YA2AEDDR";

        /// <summary>
        /// Q2YA2NCDDR.
        /// </summary>
        public const string Q2YA2NCDDR = "Q2YA2NCDDR";

        /// <summary>
        /// Q2YC2BEDDR.
        /// </summary>
        public const string Q2YC2BEDDR = "Q2YC2BEDDR";

        /// <summary>
        /// Q2YC2SEDDR.
        /// </summary>
        public const string Q2YC2SEDDR = "Q2YC2SEDDR";

        /// <summary>
        /// Q2YC2AEDDR.
        /// </summary>
        public const string Q2YC2AEDDR = "Q2YC2AEDDR";

        /// <summary>
        /// Q2YC2NCDDR.
        /// </summary>
        public const string Q2YC2NCDDR = "Q2YC2NCDDR";

        /// <summary>
        /// Q2YPLBEDCR.
        /// </summary>
        public const string Q2YPLBEDCR = "Q2YPLBEDCR";

        /// <summary>
        /// Q2YPLSEDCR.
        /// </summary>
        public const string Q2YPLSEDCR = "Q2YPLSEDCR";

        /// <summary>
        /// Q2YPLAEDCR.
        /// </summary>
        public const string Q2YPLAEDCR = "Q2YPLAEDCR";

        /// <summary>
        /// Q2YPLNCDCR.
        /// </summary>
        public const string Q2YPLNCDCR = "Q2YPLNCDCR";

        /// <summary>
        /// Q2YA2BEDCR.
        /// </summary>
        public const string Q2YA2BEDCR = "Q2YA2BEDCR";

        /// <summary>
        /// Q2YA2SEDCR.
        /// </summary>
        public const string Q2YA2SEDCR = "Q2YA2SEDCR";

        /// <summary>
        /// Q2YA2AEDCR.
        /// </summary>
        public const string Q2YA2AEDCR = "Q2YA2AEDCR";

        /// <summary>
        /// Q2YA2NCDCR.
        /// </summary>
        public const string Q2YA2NCDCR = "Q2YA2NCDCR";

        /// <summary>
        /// Q2YC2BEDCR.
        /// </summary>
        public const string Q2YC2BEDCR = "Q2YC2BEDCR";

        /// <summary>
        /// Q2YC2SEDCR.
        /// </summary>
        public const string Q2YC2SEDCR = "Q2YC2SEDCR";

        /// <summary>
        /// Q2YC2AEDCR.
        /// </summary>
        public const string Q2YC2AEDCR = "Q2YC2AEDCR";

        /// <summary>
        /// Q2YC2NCDCR.
        /// </summary>
        public const string Q2YC2NCDCR = "Q2YC2NCDCR";

        /// <summary>
        /// Q2YPLBEDCB.
        /// </summary>
        public const string Q2YPLBEDCB = "Q2YPLBEDCB";

        /// <summary>
        /// Q2YPLSEDCB.
        /// </summary>
        public const string Q2YPLSEDCB = "Q2YPLSEDCB";

        /// <summary>
        /// Q2YPLAEDCB.
        /// </summary>
        public const string Q2YPLAEDCB = "Q2YPLAEDCB";

        /// <summary>
        /// Q2YPLNCDCB.
        /// </summary>
        public const string Q2YPLNCDCB = "Q2YPLNCDCB";

        /// <summary>
        /// Q2YA2BEDCB.
        /// </summary>
        public const string Q2YA2BEDCB = "Q2YA2BEDCB";

        /// <summary>
        /// Q2YA2SEDCB.
        /// </summary>
        public const string Q2YA2SEDCB = "Q2YA2SEDCB";

        /// <summary>
        /// Q2YA2AEDCB.
        /// </summary>
        public const string Q2YA2AEDCB = "Q2YA2AEDCB";

        /// <summary>
        /// Q2YA2NCDCB.
        /// </summary>
        public const string Q2YA2NCDCB = "Q2YA2NCDCB";

        /// <summary>
        /// Q2YC2BEDCB.
        /// </summary>
        public const string Q2YC2BEDCB = "Q2YC2BEDCB";

        /// <summary>
        /// Q2YC2SEDCB.
        /// </summary>
        public const string Q2YC2SEDCB = "Q2YC2SEDCB";

        /// <summary>
        /// Q2YA2ECCB.
        /// </summary>
        public const string Q2YA2ECCB = "Q2YA2ECCB";

        /// <summary>
        /// Q2YA2ECCR.
        /// </summary>
        public const string Q2YA2ECCR = "Q2YA2ECCR";

        /// <summary>
        /// Q2YC2AEDCB.
        /// </summary>
        public const string Q2YC2AEDCB = "Q2YC2AEDCB";

        /// <summary>
        /// Q2YA2ECOP.
        /// </summary>
        public const string Q2YA2ECOP = "Q2YA2ECOP";

        /// <summary>
        /// Q2YA2ECDR.
        /// </summary>
        public const string Q2YA2ECDR = "Q2YA2ECDR";

        /// <summary>
        /// Q2YC2ECCR.
        /// </summary>
        public const string Q2YC2ECCR = "Q2YC2ECCR";

        /// <summary>
        /// Q2YC2ECDR.
        /// </summary>
        public const string Q2YC2ECDR = "Q2YC2ECDR";

        /// <summary>
        /// Q2YC2ECCB.
        /// </summary>
        public const string Q2YC2ECCB = "Q2YC2ECCB";

        /// <summary>
        /// Q2YC2ECOP.
        /// </summary>
        public const string Q2YC2ECOP = "Q2YC2ECOP";

        /// <summary>
        /// Q2YPLECCB.
        /// </summary>
        public const string Q2YPLECCB = "Q2YPLECCB";

        /// <summary>
        /// Q2YPLECCR.
        /// </summary>
        public const string Q2YPLECCR = "Q2YPLECCR";

        /// <summary>
        /// Q2YPLECDR.
        /// </summary>
        public const string Q2YPLECDR = "Q2YPLECDR";

        /// <summary>
        /// Q2YPLECOP.
        /// </summary>
        public const string Q2YPLECOP = "Q2YPLECOP";

        /// <summary>
        /// Q2YC2NCDCB.
        /// </summary>
        public const string Q2YC2NCDCB = "Q2YC2NCDCB";

        /// <summary>
        /// Q2A2CVDDR.
        /// </summary>
        public const string Q2A2CVDDR = "Q2A2CVDDR";

        /// <summary>
        /// Q2A2CVDCR.
        /// </summary>
        public const string Q2A2CVDCR = "Q2A2CVDCR";

        /// <summary>
        /// Q2A2CVDOB.
        /// </summary>
        public const string Q2A2CVDOB = "Q2A2CVDOB";

        /// <summary>
        /// Q2A2CVDCB.
        /// </summary>
        public const string Q2A2CVDCB = "Q2A2CVDCB";

        /// <summary>
        /// Q2C2CVDOB.
        /// </summary>
        public const string Q2C2CVDOB = "Q2C2CVDOB";

        /// <summary>
        /// Q2C2CVDCR.
        /// </summary>
        public const string Q2C2CVDCR = "Q2C2CVDCR";

        /// <summary>
        /// Q2C2CVDDR.
        /// </summary>
        public const string Q2C2CVDDR = "Q2C2CVDDR";

        /// <summary>
        /// Q2C2CVDCB.
        /// </summary>
        public const string Q2C2CVDCB = "Q2C2CVDCB";

        /// <summary>
        /// Q2A2CVCDR.
        /// </summary>
        public const string Q2A2CVCDR = "Q2A2CVCDR";

        /// <summary>
        /// Q2A2CVCCR.
        /// </summary>
        public const string Q2A2CVCCR = "Q2A2CVCCR";

        /// <summary>
        /// Q2A2CVCOB.
        /// </summary>
        public const string Q2A2CVCOB = "Q2A2CVCOB";

        /// <summary>
        /// Q2A2CVCCB.
        /// </summary>
        public const string Q2A2CVCCB = "Q2A2CVCCB";

        /// <summary>
        /// Q2C2CVCOB.
        /// </summary>
        public const string Q2C2CVCOB = "Q2C2CVCOB";

        /// <summary>
        /// Q2C2CVCCR.
        /// </summary>
        public const string Q2C2CVCCR = "Q2C2CVCCR";

        /// <summary>
        /// Q2C2CVCDR.
        /// </summary>
        public const string Q2C2CVCDR = "Q2C2CVCDR";

        /// <summary>
        /// Q2C2CVCCB.
        /// </summary>
        public const string Q2C2CVCCB = "Q2C2CVCCB";

        /// <summary>
        /// Q2TDAY.
        /// </summary>
        public const string Q2TDAY = "Q2TDAY";

        /// <summary>
        /// Q2JOBN.
        /// </summary>
        public const string Q2JOBN = "Q2JOBN";

        /// <summary>
        /// Q2PID.
        /// </summary>
        public const string Q2PID = "Q2PID";

        /// <summary>
        /// Q2UPMJ.
        /// </summary>
        public const string Q2UPMJ = "Q2UPMJ";

        /// <summary>
        /// Q2USER.
        /// </summary>
        public const string Q2USER = "Q2USER";

        /// <summary>
        /// Q2TORG.
        /// </summary>
        public const string Q2TORG = "Q2TORG";
    }

    /// <inheritdoc />
    public override string TableName => "F75I310Y";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Q2YEXU", "Q2YEXU", JdeDataType.Numeric, null, true, true),
        new JdeField("Q2YRM", "Q2YRM", JdeDataType.Numeric, null, true, true),
        new JdeField("Q2MNTH", "Q2MNTH", JdeDataType.Numeric, null, true, true),
        new JdeField("Q2YMCB", "Q2YMCB", JdeDataType.Numeric),
        new JdeField("Q2YMCR", "Q2YMCR", JdeDataType.Numeric),
        new JdeField("Q2YMDR", "Q2YMDR", JdeDataType.Numeric),
        new JdeField("Q2YMOB", "Q2YMOB", JdeDataType.Numeric),
        new JdeField("Q2YNXE", "Q2YNXE", JdeDataType.Numeric),
        new JdeField("Q2YMBA", "Q2YMBA", JdeDataType.Numeric),
        new JdeField("Q2YPCB", "Q2YPCB", JdeDataType.Numeric),
        new JdeField("Q2YPCR", "Q2YPCR", JdeDataType.Numeric),
        new JdeField("Q2YPDR", "Q2YPDR", JdeDataType.Numeric),
        new JdeField("Q2YPOB", "Q2YPOB", JdeDataType.Numeric),
        new JdeField("Q2YNXP", "Q2YNXP", JdeDataType.Numeric),
        new JdeField("Q2YCCB", "Q2YCCB", JdeDataType.Numeric),
        new JdeField("Q2YCCR", "Q2YCCR", JdeDataType.Numeric),
        new JdeField("Q2YCDR", "Q2YCDR", JdeDataType.Numeric),
        new JdeField("Q2YCOB", "Q2YCOB", JdeDataType.Numeric),
        new JdeField("Q2YCXP", "Q2YCXP", JdeDataType.Numeric),
        new JdeField("Q2YCBA", "Q2YCBA", JdeDataType.Numeric),
        new JdeField("Q2YDCB", "Q2YDCB", JdeDataType.Numeric),
        new JdeField("Q2YDCR", "Q2YDCR", JdeDataType.Numeric),
        new JdeField("Q2YDDR", "Q2YDDR", JdeDataType.Numeric),
        new JdeField("Q2YDOB", "Q2YDOB", JdeDataType.Numeric),
        new JdeField("Q2YDXP", "Q2YDXP", JdeDataType.Numeric),
        new JdeField("Q2YAR3N", "Q2YAR3N", JdeDataType.Numeric),
        new JdeField("Q2YARN", "Q2YARN", JdeDataType.Numeric),
        new JdeField("Q2YD3N", "Q2YD3N", JdeDataType.Numeric),
        new JdeField("Q2YPLBEDOP", "Q2YPLBEDOP", JdeDataType.Numeric),
        new JdeField("Q2YPLSEDOP", "Q2YPLSEDOP", JdeDataType.Numeric),
        new JdeField("Q2YPLAEDOP", "Q2YPLAEDOP", JdeDataType.Numeric),
        new JdeField("Q2YPLNCDOP", "Q2YPLNCDOP", JdeDataType.Numeric),
        new JdeField("Q2YA2BEDOP", "Q2YA2BEDOP", JdeDataType.Numeric),
        new JdeField("Q2YA2SEDOP", "Q2YA2SEDOP", JdeDataType.Numeric),
        new JdeField("Q2YA2AEDOP", "Q2YA2AEDOP", JdeDataType.Numeric),
        new JdeField("Q2YA2NCDOP", "Q2YA2NCDOP", JdeDataType.Numeric),
        new JdeField("Q2YC2BEDOP", "Q2YC2BEDOP", JdeDataType.Numeric),
        new JdeField("Q2YC2SEDOP", "Q2YC2SEDOP", JdeDataType.Numeric),
        new JdeField("Q2YC2AEDOP", "Q2YC2AEDOP", JdeDataType.Numeric),
        new JdeField("Q2YC2NCDOP", "Q2YC2NCDOP", JdeDataType.Numeric),
        new JdeField("Q2YPLBEDDR", "Q2YPLBEDDR", JdeDataType.Numeric),
        new JdeField("Q2YPLSEDDR", "Q2YPLSEDDR", JdeDataType.Numeric),
        new JdeField("Q2YPLAEDDR", "Q2YPLAEDDR", JdeDataType.Numeric),
        new JdeField("Q2YPLNCDDR", "Q2YPLNCDDR", JdeDataType.Numeric),
        new JdeField("Q2YA2BEDDR", "Q2YA2BEDDR", JdeDataType.Numeric),
        new JdeField("Q2YA2SEDDR", "Q2YA2SEDDR", JdeDataType.Numeric),
        new JdeField("Q2YA2AEDDR", "Q2YA2AEDDR", JdeDataType.Numeric),
        new JdeField("Q2YA2NCDDR", "Q2YA2NCDDR", JdeDataType.Numeric),
        new JdeField("Q2YC2BEDDR", "Q2YC2BEDDR", JdeDataType.Numeric),
        new JdeField("Q2YC2SEDDR", "Q2YC2SEDDR", JdeDataType.Numeric),
        new JdeField("Q2YC2AEDDR", "Q2YC2AEDDR", JdeDataType.Numeric),
        new JdeField("Q2YC2NCDDR", "Q2YC2NCDDR", JdeDataType.Numeric),
        new JdeField("Q2YPLBEDCR", "Q2YPLBEDCR", JdeDataType.Numeric),
        new JdeField("Q2YPLSEDCR", "Q2YPLSEDCR", JdeDataType.Numeric),
        new JdeField("Q2YPLAEDCR", "Q2YPLAEDCR", JdeDataType.Numeric),
        new JdeField("Q2YPLNCDCR", "Q2YPLNCDCR", JdeDataType.Numeric),
        new JdeField("Q2YA2BEDCR", "Q2YA2BEDCR", JdeDataType.Numeric),
        new JdeField("Q2YA2SEDCR", "Q2YA2SEDCR", JdeDataType.Numeric),
        new JdeField("Q2YA2AEDCR", "Q2YA2AEDCR", JdeDataType.Numeric),
        new JdeField("Q2YA2NCDCR", "Q2YA2NCDCR", JdeDataType.Numeric),
        new JdeField("Q2YC2BEDCR", "Q2YC2BEDCR", JdeDataType.Numeric),
        new JdeField("Q2YC2SEDCR", "Q2YC2SEDCR", JdeDataType.Numeric),
        new JdeField("Q2YC2AEDCR", "Q2YC2AEDCR", JdeDataType.Numeric),
        new JdeField("Q2YC2NCDCR", "Q2YC2NCDCR", JdeDataType.Numeric),
        new JdeField("Q2YPLBEDCB", "Q2YPLBEDCB", JdeDataType.Numeric),
        new JdeField("Q2YPLSEDCB", "Q2YPLSEDCB", JdeDataType.Numeric),
        new JdeField("Q2YPLAEDCB", "Q2YPLAEDCB", JdeDataType.Numeric),
        new JdeField("Q2YPLNCDCB", "Q2YPLNCDCB", JdeDataType.Numeric),
        new JdeField("Q2YA2BEDCB", "Q2YA2BEDCB", JdeDataType.Numeric),
        new JdeField("Q2YA2SEDCB", "Q2YA2SEDCB", JdeDataType.Numeric),
        new JdeField("Q2YA2AEDCB", "Q2YA2AEDCB", JdeDataType.Numeric),
        new JdeField("Q2YA2NCDCB", "Q2YA2NCDCB", JdeDataType.Numeric),
        new JdeField("Q2YC2BEDCB", "Q2YC2BEDCB", JdeDataType.Numeric),
        new JdeField("Q2YC2SEDCB", "Q2YC2SEDCB", JdeDataType.Numeric),
        new JdeField("Q2YA2ECCB", "Q2YA2ECCB", JdeDataType.Numeric),
        new JdeField("Q2YA2ECCR", "Q2YA2ECCR", JdeDataType.Numeric),
        new JdeField("Q2YC2AEDCB", "Q2YC2AEDCB", JdeDataType.Numeric),
        new JdeField("Q2YA2ECOP", "Q2YA2ECOP", JdeDataType.Numeric),
        new JdeField("Q2YA2ECDR", "Q2YA2ECDR", JdeDataType.Numeric),
        new JdeField("Q2YC2ECCR", "Q2YC2ECCR", JdeDataType.Numeric),
        new JdeField("Q2YC2ECDR", "Q2YC2ECDR", JdeDataType.Numeric),
        new JdeField("Q2YC2ECCB", "Q2YC2ECCB", JdeDataType.Numeric),
        new JdeField("Q2YC2ECOP", "Q2YC2ECOP", JdeDataType.Numeric),
        new JdeField("Q2YPLECCB", "Q2YPLECCB", JdeDataType.Numeric),
        new JdeField("Q2YPLECCR", "Q2YPLECCR", JdeDataType.Numeric),
        new JdeField("Q2YPLECDR", "Q2YPLECDR", JdeDataType.Numeric),
        new JdeField("Q2YPLECOP", "Q2YPLECOP", JdeDataType.Numeric),
        new JdeField("Q2YC2NCDCB", "Q2YC2NCDCB", JdeDataType.Numeric),
        new JdeField("Q2A2CVDDR", "Q2A2CVDDR", JdeDataType.Numeric),
        new JdeField("Q2A2CVDCR", "Q2A2CVDCR", JdeDataType.Numeric),
        new JdeField("Q2A2CVDOB", "Q2A2CVDOB", JdeDataType.Numeric),
        new JdeField("Q2A2CVDCB", "Q2A2CVDCB", JdeDataType.Numeric),
        new JdeField("Q2C2CVDOB", "Q2C2CVDOB", JdeDataType.Numeric),
        new JdeField("Q2C2CVDCR", "Q2C2CVDCR", JdeDataType.Numeric),
        new JdeField("Q2C2CVDDR", "Q2C2CVDDR", JdeDataType.Numeric),
        new JdeField("Q2C2CVDCB", "Q2C2CVDCB", JdeDataType.Numeric),
        new JdeField("Q2A2CVCDR", "Q2A2CVCDR", JdeDataType.Numeric),
        new JdeField("Q2A2CVCCR", "Q2A2CVCCR", JdeDataType.Numeric),
        new JdeField("Q2A2CVCOB", "Q2A2CVCOB", JdeDataType.Numeric),
        new JdeField("Q2A2CVCCB", "Q2A2CVCCB", JdeDataType.Numeric),
        new JdeField("Q2C2CVCOB", "Q2C2CVCOB", JdeDataType.Numeric),
        new JdeField("Q2C2CVCCR", "Q2C2CVCCR", JdeDataType.Numeric),
        new JdeField("Q2C2CVCDR", "Q2C2CVCDR", JdeDataType.Numeric),
        new JdeField("Q2C2CVCCB", "Q2C2CVCCB", JdeDataType.Numeric),
        new JdeField("Q2TDAY", "Q2TDAY", JdeDataType.Numeric),
        new JdeField("Q2JOBN", "Q2JOBN", JdeDataType.String, 20),
        new JdeField("Q2PID", "Q2PID", JdeDataType.String, 20),
        new JdeField("Q2UPMJ", "Q2UPMJ", JdeDataType.Numeric),
        new JdeField("Q2USER", "Q2USER", JdeDataType.String, 20),
        new JdeField("Q2TORG", "Q2TORG", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I310Y_0", "Primary Key on Q2YEXU, Q2YRM, Q2MNTH", new[] { "Q2YEXU", "Q2YRM", "Q2MNTH" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I310Y_2", "Index on Q2YEXU, SYS_NC00111$, SYS_NC00112$", new[] { "Q2YEXU", "SYS_NC00111$", "SYS_NC00112$" })
    };
}
