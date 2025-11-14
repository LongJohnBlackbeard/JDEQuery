using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F34X101W - .
/// </summary>
public class F34X101W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ISUSER.
        /// </summary>
        public const string ISUSER = "ISUSER";

        /// <summary>
        /// ISJOBS.
        /// </summary>
        public const string ISJOBS = "ISJOBS";

        /// <summary>
        /// ISITM.
        /// </summary>
        public const string ISITM = "ISITM";

        /// <summary>
        /// ISMCU.
        /// </summary>
        public const string ISMCU = "ISMCU";

        /// <summary>
        /// ISSEQ.
        /// </summary>
        public const string ISSEQ = "ISSEQ";

        /// <summary>
        /// ISUITM.
        /// </summary>
        public const string ISUITM = "ISUITM";

        /// <summary>
        /// ISANPL.
        /// </summary>
        public const string ISANPL = "ISANPL";

        /// <summary>
        /// ISPRP4.
        /// </summary>
        public const string ISPRP4 = "ISPRP4";

        /// <summary>
        /// ISMPST.
        /// </summary>
        public const string ISMPST = "ISMPST";

        /// <summary>
        /// ISVEND.
        /// </summary>
        public const string ISVEND = "ISVEND";

        /// <summary>
        /// ISBUYR.
        /// </summary>
        public const string ISBUYR = "ISBUYR";

        /// <summary>
        /// ISSAFE.
        /// </summary>
        public const string ISSAFE = "ISSAFE";

        /// <summary>
        /// ISPQOH.
        /// </summary>
        public const string ISPQOH = "ISPQOH";

        /// <summary>
        /// ISUOM1.
        /// </summary>
        public const string ISUOM1 = "ISUOM1";

        /// <summary>
        /// IS34XC01.
        /// </summary>
        public const string IS34XC01 = "IS34XC01";

        /// <summary>
        /// IS34XC02.
        /// </summary>
        public const string IS34XC02 = "IS34XC02";

        /// <summary>
        /// IS34XC03.
        /// </summary>
        public const string IS34XC03 = "IS34XC03";

        /// <summary>
        /// IS34XC04.
        /// </summary>
        public const string IS34XC04 = "IS34XC04";

        /// <summary>
        /// IS34XC05.
        /// </summary>
        public const string IS34XC05 = "IS34XC05";

        /// <summary>
        /// IS34XC06.
        /// </summary>
        public const string IS34XC06 = "IS34XC06";

        /// <summary>
        /// IS34XC07.
        /// </summary>
        public const string IS34XC07 = "IS34XC07";

        /// <summary>
        /// IS34XC08.
        /// </summary>
        public const string IS34XC08 = "IS34XC08";

        /// <summary>
        /// IS34XC09.
        /// </summary>
        public const string IS34XC09 = "IS34XC09";

        /// <summary>
        /// IS34XC10.
        /// </summary>
        public const string IS34XC10 = "IS34XC10";

        /// <summary>
        /// IS34XC11.
        /// </summary>
        public const string IS34XC11 = "IS34XC11";

        /// <summary>
        /// IS34XC12.
        /// </summary>
        public const string IS34XC12 = "IS34XC12";

        /// <summary>
        /// IS34XC13.
        /// </summary>
        public const string IS34XC13 = "IS34XC13";

        /// <summary>
        /// IS34XC14.
        /// </summary>
        public const string IS34XC14 = "IS34XC14";

        /// <summary>
        /// IS34XC15.
        /// </summary>
        public const string IS34XC15 = "IS34XC15";

        /// <summary>
        /// IS34XC16.
        /// </summary>
        public const string IS34XC16 = "IS34XC16";

        /// <summary>
        /// IS34XC17.
        /// </summary>
        public const string IS34XC17 = "IS34XC17";

        /// <summary>
        /// ISSTKT.
        /// </summary>
        public const string ISSTKT = "ISSTKT";

        /// <summary>
        /// IS34XDOSC.
        /// </summary>
        public const string IS34XDOSC = "IS34XDOSC";

        /// <summary>
        /// IS34XDOS1.
        /// </summary>
        public const string IS34XDOS1 = "IS34XDOS1";

        /// <summary>
        /// IS34XDOS2.
        /// </summary>
        public const string IS34XDOS2 = "IS34XDOS2";

        /// <summary>
        /// IS34XDOSS.
        /// </summary>
        public const string IS34XDOSS = "IS34XDOSS";

        /// <summary>
        /// IS34XIOHS.
        /// </summary>
        public const string IS34XIOHS = "IS34XIOHS";

        /// <summary>
        /// IS34XDUR1.
        /// </summary>
        public const string IS34XDUR1 = "IS34XDUR1";

        /// <summary>
        /// IS34XDUR2.
        /// </summary>
        public const string IS34XDUR2 = "IS34XDUR2";

        /// <summary>
        /// ISUPMJ.
        /// </summary>
        public const string ISUPMJ = "ISUPMJ";

        /// <summary>
        /// IS34XDAL1.
        /// </summary>
        public const string IS34XDAL1 = "IS34XDAL1";

        /// <summary>
        /// IS34XDAL2.
        /// </summary>
        public const string IS34XDAL2 = "IS34XDAL2";

        /// <summary>
        /// IS34XDAL3.
        /// </summary>
        public const string IS34XDAL3 = "IS34XDAL3";

        /// <summary>
        /// IS34XEANG.
        /// </summary>
        public const string IS34XEANG = "IS34XEANG";

        /// <summary>
        /// IS34XCNCD.
        /// </summary>
        public const string IS34XCNCD = "IS34XCNCD";

        /// <summary>
        /// IS34XLATN.
        /// </summary>
        public const string IS34XLATN = "IS34XLATN";
    }

    /// <inheritdoc />
    public override string TableName => "F34X101W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ISUSER", "ISUSER", JdeDataType.String, 20, true, true),
        new JdeField("ISJOBS", "ISJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("ISITM", "ISITM", JdeDataType.Numeric, null, true, true),
        new JdeField("ISMCU", "ISMCU", JdeDataType.String, 24, true, true),
        new JdeField("ISSEQ", "ISSEQ", JdeDataType.Numeric),
        new JdeField("ISUITM", "ISUITM", JdeDataType.String, 52),
        new JdeField("ISANPL", "ISANPL", JdeDataType.Numeric),
        new JdeField("ISPRP4", "ISPRP4", JdeDataType.String, 6),
        new JdeField("ISMPST", "ISMPST", JdeDataType.String, 2),
        new JdeField("ISVEND", "ISVEND", JdeDataType.Numeric),
        new JdeField("ISBUYR", "ISBUYR", JdeDataType.Numeric),
        new JdeField("ISSAFE", "ISSAFE", JdeDataType.Numeric),
        new JdeField("ISPQOH", "ISPQOH", JdeDataType.Numeric),
        new JdeField("ISUOM1", "ISUOM1", JdeDataType.String, 4),
        new JdeField("IS34XC01", "IS34XC01", JdeDataType.Numeric),
        new JdeField("IS34XC02", "IS34XC02", JdeDataType.Numeric),
        new JdeField("IS34XC03", "IS34XC03", JdeDataType.Numeric),
        new JdeField("IS34XC04", "IS34XC04", JdeDataType.Numeric),
        new JdeField("IS34XC05", "IS34XC05", JdeDataType.Numeric),
        new JdeField("IS34XC06", "IS34XC06", JdeDataType.Numeric),
        new JdeField("IS34XC07", "IS34XC07", JdeDataType.Numeric),
        new JdeField("IS34XC08", "IS34XC08", JdeDataType.Numeric),
        new JdeField("IS34XC09", "IS34XC09", JdeDataType.Numeric),
        new JdeField("IS34XC10", "IS34XC10", JdeDataType.Numeric),
        new JdeField("IS34XC11", "IS34XC11", JdeDataType.Numeric),
        new JdeField("IS34XC12", "IS34XC12", JdeDataType.Numeric),
        new JdeField("IS34XC13", "IS34XC13", JdeDataType.Numeric),
        new JdeField("IS34XC14", "IS34XC14", JdeDataType.Numeric),
        new JdeField("IS34XC15", "IS34XC15", JdeDataType.Numeric),
        new JdeField("IS34XC16", "IS34XC16", JdeDataType.Numeric),
        new JdeField("IS34XC17", "IS34XC17", JdeDataType.Numeric),
        new JdeField("ISSTKT", "ISSTKT", JdeDataType.String, 2),
        new JdeField("IS34XDOSC", "IS34XDOSC", JdeDataType.Numeric),
        new JdeField("IS34XDOS1", "IS34XDOS1", JdeDataType.Numeric),
        new JdeField("IS34XDOS2", "IS34XDOS2", JdeDataType.Numeric),
        new JdeField("IS34XDOSS", "IS34XDOSS", JdeDataType.String, 2),
        new JdeField("IS34XIOHS", "IS34XIOHS", JdeDataType.Numeric),
        new JdeField("IS34XDUR1", "IS34XDUR1", JdeDataType.Numeric),
        new JdeField("IS34XDUR2", "IS34XDUR2", JdeDataType.Numeric),
        new JdeField("ISUPMJ", "ISUPMJ", JdeDataType.Numeric),
        new JdeField("IS34XDAL1", "IS34XDAL1", JdeDataType.Numeric),
        new JdeField("IS34XDAL2", "IS34XDAL2", JdeDataType.Numeric),
        new JdeField("IS34XDAL3", "IS34XDAL3", JdeDataType.Numeric),
        new JdeField("IS34XEANG", "IS34XEANG", JdeDataType.String, 2),
        new JdeField("IS34XCNCD", "IS34XCNCD", JdeDataType.Numeric),
        new JdeField("IS34XLATN", "IS34XLATN", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F34X101W_0", "Primary Key on ISUSER, ISJOBS, ISITM, ISMCU", new[] { "ISUSER", "ISJOBS", "ISITM", "ISMCU" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F34X101W_2", "Index on ISUSER, ISJOBS, ISSEQ", new[] { "ISUSER", "ISJOBS", "ISSEQ" }),
        new JdeIndex("F34X101W_3", "Index on ISUSER, ISJOBS, ISUPMJ", new[] { "ISUSER", "ISJOBS", "ISUPMJ" })
    };
}
