using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I848 - .
/// </summary>
public class F75I848 : JdeTable
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
        /// SIKCO.
        /// </summary>
        public const string SIKCO = "SIKCO";

        /// <summary>
        /// SII75GSTU.
        /// </summary>
        public const string SII75GSTU = "SII75GSTU";

        /// <summary>
        /// SIDOC.
        /// </summary>
        public const string SIDOC = "SIDOC";

        /// <summary>
        /// SIPYID.
        /// </summary>
        public const string SIPYID = "SIPYID";

        /// <summary>
        /// SIDCT.
        /// </summary>
        public const string SIDCT = "SIDCT";

        /// <summary>
        /// SIDGL.
        /// </summary>
        public const string SIDGL = "SIDGL";

        /// <summary>
        /// SII75INVNO.
        /// </summary>
        public const string SII75INVNO = "SII75INVNO";

        /// <summary>
        /// SII75INVST.
        /// </summary>
        public const string SII75INVST = "SII75INVST";

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

        /// <summary>
        /// SII75INVSR.
        /// </summary>
        public const string SII75INVSR = "SII75INVSR";

        /// <summary>
        /// SIDOCO.
        /// </summary>
        public const string SIDOCO = "SIDOCO";

        /// <summary>
        /// SIKCOO.
        /// </summary>
        public const string SIKCOO = "SIKCOO";

        /// <summary>
        /// SIDCTO.
        /// </summary>
        public const string SIDCTO = "SIDCTO";

        /// <summary>
        /// SII75DOCTY.
        /// </summary>
        public const string SII75DOCTY = "SII75DOCTY";
    }

    /// <inheritdoc />
    public override string TableName => "F75I848";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SIUKID", "SIUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("SIKCO", "SIKCO", JdeDataType.String, 10),
        new JdeField("SII75GSTU", "SII75GSTU", JdeDataType.Numeric),
        new JdeField("SIDOC", "SIDOC", JdeDataType.Numeric),
        new JdeField("SIPYID", "SIPYID", JdeDataType.Numeric),
        new JdeField("SIDCT", "SIDCT", JdeDataType.String, 4),
        new JdeField("SIDGL", "SIDGL", JdeDataType.Numeric),
        new JdeField("SII75INVNO", "SII75INVNO", JdeDataType.String, 50),
        new JdeField("SII75INVST", "SII75INVST", JdeDataType.String, 2),
        new JdeField("SIUSER", "SIUSER", JdeDataType.String, 20),
        new JdeField("SIPID", "SIPID", JdeDataType.String, 20),
        new JdeField("SIJOBN", "SIJOBN", JdeDataType.String, 20),
        new JdeField("SIUPMJ", "SIUPMJ", JdeDataType.Numeric),
        new JdeField("SIUPMT", "SIUPMT", JdeDataType.Numeric),
        new JdeField("SIYFUTDT1", "SIYFUTDT1", JdeDataType.Numeric),
        new JdeField("SIFUT6", "SIFUT6", JdeDataType.String, 60),
        new JdeField("SIYT04", "SIYT04", JdeDataType.String, 2),
        new JdeField("SIYFLAG", "SIYFLAG", JdeDataType.String, 2),
        new JdeField("SIYNUM1", "SIYNUM1", JdeDataType.Numeric),
        new JdeField("SII75INVSR", "SII75INVSR", JdeDataType.String, 20),
        new JdeField("SIDOCO", "SIDOCO", JdeDataType.Numeric),
        new JdeField("SIKCOO", "SIKCOO", JdeDataType.String, 10),
        new JdeField("SIDCTO", "SIDCTO", JdeDataType.String, 4),
        new JdeField("SII75DOCTY", "SII75DOCTY", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I848_0", "Primary Key on SIUKID", new[] { "SIUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I848_2", "Index on SIKCO, SII75GSTU, SIPYID, SIDCT, SIDGL", new[] { "SIKCO", "SII75GSTU", "SIPYID", "SIDCT", "SIDGL" }),
        new JdeIndex("F75I848_3", "Index on SIKCO, SII75GSTU, SIDOC, SIDCT, SIDGL", new[] { "SIKCO", "SII75GSTU", "SIDOC", "SIDCT", "SIDGL" }),
        new JdeIndex("F75I848_4", "Index on SIKCOO, SIDCTO, SII75GSTU, SIDGL, SIDOCO", new[] { "SIKCOO", "SIDCTO", "SII75GSTU", "SIDGL", "SIDOCO" })
    };
}
