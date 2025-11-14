using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74YUI01 - .
/// </summary>
public class F74YUI01 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LCJOBS.
        /// </summary>
        public const string LCJOBS = "LCJOBS";

        /// <summary>
        /// LCTAX.
        /// </summary>
        public const string LCTAX = "LCTAX";

        /// <summary>
        /// LCTX2.
        /// </summary>
        public const string LCTX2 = "LCTX2";

        /// <summary>
        /// LCAD1I.
        /// </summary>
        public const string LCAD1I = "LCAD1I";

        /// <summary>
        /// LCAD2I.
        /// </summary>
        public const string LCAD2I = "LCAD2I";

        /// <summary>
        /// LCGEND.
        /// </summary>
        public const string LCGEND = "LCGEND";

        /// <summary>
        /// LCDOB.
        /// </summary>
        public const string LCDOB = "LCDOB";

        /// <summary>
        /// LCIRLN.
        /// </summary>
        public const string LCIRLN = "LCIRLN";

        /// <summary>
        /// LCIRPN.
        /// </summary>
        public const string LCIRPN = "LCIRPN";

        /// <summary>
        /// LCALPH.
        /// </summary>
        public const string LCALPH = "LCALPH";

        /// <summary>
        /// LCCTY1.
        /// </summary>
        public const string LCCTY1 = "LCCTY1";

        /// <summary>
        /// LCADDS.
        /// </summary>
        public const string LCADDS = "LCADDS";

        /// <summary>
        /// LCTX1.
        /// </summary>
        public const string LCTX1 = "LCTX1";

        /// <summary>
        /// LCAJSY.
        /// </summary>
        public const string LCAJSY = "LCAJSY";

        /// <summary>
        /// LCINT01.
        /// </summary>
        public const string LCINT01 = "LCINT01";

        /// <summary>
        /// LCINT02.
        /// </summary>
        public const string LCINT02 = "LCINT02";

        /// <summary>
        /// LCTAX0.
        /// </summary>
        public const string LCTAX0 = "LCTAX0";

        /// <summary>
        /// LCY74NCAF.
        /// </summary>
        public const string LCY74NCAF = "LCY74NCAF";

        /// <summary>
        /// LCEV01.
        /// </summary>
        public const string LCEV01 = "LCEV01";

        /// <summary>
        /// LCCDATE.
        /// </summary>
        public const string LCCDATE = "LCCDATE";

        /// <summary>
        /// LCMATH01.
        /// </summary>
        public const string LCMATH01 = "LCMATH01";

        /// <summary>
        /// LCMATH02.
        /// </summary>
        public const string LCMATH02 = "LCMATH02";

        /// <summary>
        /// LCURCD.
        /// </summary>
        public const string LCURCD = "LCURCD";

        /// <summary>
        /// LCURDT.
        /// </summary>
        public const string LCURDT = "LCURDT";

        /// <summary>
        /// LCURAT.
        /// </summary>
        public const string LCURAT = "LCURAT";

        /// <summary>
        /// LCURRF.
        /// </summary>
        public const string LCURRF = "LCURRF";

        /// <summary>
        /// LCUSER.
        /// </summary>
        public const string LCUSER = "LCUSER";

        /// <summary>
        /// LCPID.
        /// </summary>
        public const string LCPID = "LCPID";

        /// <summary>
        /// LCJOBN.
        /// </summary>
        public const string LCJOBN = "LCJOBN";

        /// <summary>
        /// LCUPMJ.
        /// </summary>
        public const string LCUPMJ = "LCUPMJ";

        /// <summary>
        /// LCTDAY.
        /// </summary>
        public const string LCTDAY = "LCTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F74YUI01";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LCJOBS", "LCJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("LCTAX", "LCTAX", JdeDataType.String, 40),
        new JdeField("LCTX2", "LCTX2", JdeDataType.String, 40),
        new JdeField("LCAD1I", "LCAD1I", JdeDataType.String, 80),
        new JdeField("LCAD2I", "LCAD2I", JdeDataType.String, 80),
        new JdeField("LCGEND", "LCGEND", JdeDataType.String, 2),
        new JdeField("LCDOB", "LCDOB", JdeDataType.Numeric),
        new JdeField("LCIRLN", "LCIRLN", JdeDataType.String, 60),
        new JdeField("LCIRPN", "LCIRPN", JdeDataType.String, 6),
        new JdeField("LCALPH", "LCALPH", JdeDataType.String, 80),
        new JdeField("LCCTY1", "LCCTY1", JdeDataType.String, 50),
        new JdeField("LCADDS", "LCADDS", JdeDataType.String, 6),
        new JdeField("LCTX1", "LCTX1", JdeDataType.String, 32),
        new JdeField("LCAJSY", "LCAJSY", JdeDataType.Numeric),
        new JdeField("LCINT01", "LCINT01", JdeDataType.Numeric),
        new JdeField("LCINT02", "LCINT02", JdeDataType.Numeric),
        new JdeField("LCTAX0", "LCTAX0", JdeDataType.String, 32),
        new JdeField("LCY74NCAF", "LCY74NCAF", JdeDataType.Numeric),
        new JdeField("LCEV01", "LCEV01", JdeDataType.String, 2),
        new JdeField("LCCDATE", "LCCDATE", JdeDataType.Numeric),
        new JdeField("LCMATH01", "LCMATH01", JdeDataType.Numeric),
        new JdeField("LCMATH02", "LCMATH02", JdeDataType.Numeric),
        new JdeField("LCURCD", "LCURCD", JdeDataType.String, 4),
        new JdeField("LCURDT", "LCURDT", JdeDataType.Numeric),
        new JdeField("LCURAT", "LCURAT", JdeDataType.Numeric),
        new JdeField("LCURRF", "LCURRF", JdeDataType.String, 30),
        new JdeField("LCUSER", "LCUSER", JdeDataType.String, 20),
        new JdeField("LCPID", "LCPID", JdeDataType.String, 20),
        new JdeField("LCJOBN", "LCJOBN", JdeDataType.String, 20),
        new JdeField("LCUPMJ", "LCUPMJ", JdeDataType.Numeric),
        new JdeField("LCTDAY", "LCTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74YUI01_0", "Primary Key on LCJOBS", new[] { "LCJOBS" }, isUnique: true, isPrimaryKey: true)
    };
}
