using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I829 - .
/// </summary>
public class F75I829 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SIUKID.
        /// </summary>
        public const string SIUKID = "SIUKID";

        /// <summary>
        /// SIKCOO.
        /// </summary>
        public const string SIKCOO = "SIKCOO";

        /// <summary>
        /// SIDOCO.
        /// </summary>
        public const string SIDOCO = "SIDOCO";

        /// <summary>
        /// SIDCTO.
        /// </summary>
        public const string SIDCTO = "SIDCTO";

        /// <summary>
        /// SILNID.
        /// </summary>
        public const string SILNID = "SILNID";

        /// <summary>
        /// SII75NINNO.
        /// </summary>
        public const string SII75NINNO = "SII75NINNO";

        /// <summary>
        /// SII75PINNO.
        /// </summary>
        public const string SII75PINNO = "SII75PINNO";

        /// <summary>
        /// SII75NDOC.
        /// </summary>
        public const string SII75NDOC = "SII75NDOC";

        /// <summary>
        /// SII75PDOC.
        /// </summary>
        public const string SII75PDOC = "SII75PDOC";

        /// <summary>
        /// SII75NINDT.
        /// </summary>
        public const string SII75NINDT = "SII75NINDT";

        /// <summary>
        /// SII75PINDT.
        /// </summary>
        public const string SII75PINDT = "SII75PINDT";

        /// <summary>
        /// SIUITM.
        /// </summary>
        public const string SIUITM = "SIUITM";

        /// <summary>
        /// SIDSC1.
        /// </summary>
        public const string SIDSC1 = "SIDSC1";

        /// <summary>
        /// SII75NATXA.
        /// </summary>
        public const string SII75NATXA = "SII75NATXA";

        /// <summary>
        /// SII75PATXA.
        /// </summary>
        public const string SII75PATXA = "SII75PATXA";

        /// <summary>
        /// SII75NSTAM.
        /// </summary>
        public const string SII75NSTAM = "SII75NSTAM";

        /// <summary>
        /// SII75PSTAM.
        /// </summary>
        public const string SII75PSTAM = "SII75PSTAM";

        /// <summary>
        /// SIUSER.
        /// </summary>
        public const string SIUSER = "SIUSER";

        /// <summary>
        /// SIPID.
        /// </summary>
        public const string SIPID = "SIPID";

        /// <summary>
        /// SIJOBN.
        /// </summary>
        public const string SIJOBN = "SIJOBN";

        /// <summary>
        /// SIUPMJ.
        /// </summary>
        public const string SIUPMJ = "SIUPMJ";

        /// <summary>
        /// SIUPMT.
        /// </summary>
        public const string SIUPMT = "SIUPMT";

        /// <summary>
        /// SIYFUTDT1.
        /// </summary>
        public const string SIYFUTDT1 = "SIYFUTDT1";

        /// <summary>
        /// SIFUT6.
        /// </summary>
        public const string SIFUT6 = "SIFUT6";

        /// <summary>
        /// SIYT04.
        /// </summary>
        public const string SIYT04 = "SIYT04";

        /// <summary>
        /// SIYFLAG.
        /// </summary>
        public const string SIYFLAG = "SIYFLAG";

        /// <summary>
        /// SIYNUM1.
        /// </summary>
        public const string SIYNUM1 = "SIYNUM1";
    }

    /// <inheritdoc />
    public override string TableName => "F75I829";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SIUKID", "SIUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("SIKCOO", "SIKCOO", JdeDataType.String, 10, true, true),
        new JdeField("SIDOCO", "SIDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("SIDCTO", "SIDCTO", JdeDataType.String, 4, true, true),
        new JdeField("SILNID", "SILNID", JdeDataType.Numeric, null, true, true),
        new JdeField("SII75NINNO", "SII75NINNO", JdeDataType.String, 50, true, true),
        new JdeField("SII75PINNO", "SII75PINNO", JdeDataType.String, 50),
        new JdeField("SII75NDOC", "SII75NDOC", JdeDataType.Numeric),
        new JdeField("SII75PDOC", "SII75PDOC", JdeDataType.Numeric),
        new JdeField("SII75NINDT", "SII75NINDT", JdeDataType.Numeric),
        new JdeField("SII75PINDT", "SII75PINDT", JdeDataType.Numeric),
        new JdeField("SIUITM", "SIUITM", JdeDataType.String, 52),
        new JdeField("SIDSC1", "SIDSC1", JdeDataType.String, 60),
        new JdeField("SII75NATXA", "SII75NATXA", JdeDataType.Numeric),
        new JdeField("SII75PATXA", "SII75PATXA", JdeDataType.Numeric),
        new JdeField("SII75NSTAM", "SII75NSTAM", JdeDataType.Numeric),
        new JdeField("SII75PSTAM", "SII75PSTAM", JdeDataType.Numeric),
        new JdeField("SIUSER", "SIUSER", JdeDataType.String, 20),
        new JdeField("SIPID", "SIPID", JdeDataType.String, 20),
        new JdeField("SIJOBN", "SIJOBN", JdeDataType.String, 20),
        new JdeField("SIUPMJ", "SIUPMJ", JdeDataType.Numeric),
        new JdeField("SIUPMT", "SIUPMT", JdeDataType.Numeric),
        new JdeField("SIYFUTDT1", "SIYFUTDT1", JdeDataType.Numeric),
        new JdeField("SIFUT6", "SIFUT6", JdeDataType.String, 60),
        new JdeField("SIYT04", "SIYT04", JdeDataType.String, 2),
        new JdeField("SIYFLAG", "SIYFLAG", JdeDataType.String, 2),
        new JdeField("SIYNUM1", "SIYNUM1", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I829_0", "Primary Key on SIUKID, SIKCOO, SIDOCO, SIDCTO, SILNID, SII75NINNO", new[] { "SIUKID", "SIKCOO", "SIDOCO", "SIDCTO", "SILNID", "SII75NINNO" }, isUnique: true, isPrimaryKey: true)
    };
}
