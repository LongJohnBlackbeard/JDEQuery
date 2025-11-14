using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4957 - .
/// </summary>
public class F4957 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BCSHPN.
        /// </summary>
        public const string BCSHPN = "BCSHPN";

        /// <summary>
        /// BCVMCU.
        /// </summary>
        public const string BCVMCU = "BCVMCU";

        /// <summary>
        /// BCLDNM.
        /// </summary>
        public const string BCLDNM = "BCLDNM";

        /// <summary>
        /// BCTRPL.
        /// </summary>
        public const string BCTRPL = "BCTRPL";

        /// <summary>
        /// BCLDDT.
        /// </summary>
        public const string BCLDDT = "BCLDDT";

        /// <summary>
        /// BCLDTM.
        /// </summary>
        public const string BCLDTM = "BCLDTM";

        /// <summary>
        /// BCADDJ.
        /// </summary>
        public const string BCADDJ = "BCADDJ";

        /// <summary>
        /// BCADTM.
        /// </summary>
        public const string BCADTM = "BCADTM";

        /// <summary>
        /// BCDLDT.
        /// </summary>
        public const string BCDLDT = "BCDLDT";

        /// <summary>
        /// BCDLTM.
        /// </summary>
        public const string BCDLTM = "BCDLTM";

        /// <summary>
        /// BCWGTS.
        /// </summary>
        public const string BCWGTS = "BCWGTS";

        /// <summary>
        /// BCWTUM.
        /// </summary>
        public const string BCWTUM = "BCWTUM";

        /// <summary>
        /// BCRLNO.
        /// </summary>
        public const string BCRLNO = "BCRLNO";

        /// <summary>
        /// BCCARS.
        /// </summary>
        public const string BCCARS = "BCCARS";

        /// <summary>
        /// BCMOT.
        /// </summary>
        public const string BCMOT = "BCMOT";

        /// <summary>
        /// BCURCD.
        /// </summary>
        public const string BCURCD = "BCURCD";

        /// <summary>
        /// BCURDT.
        /// </summary>
        public const string BCURDT = "BCURDT";

        /// <summary>
        /// BCURAT.
        /// </summary>
        public const string BCURAT = "BCURAT";

        /// <summary>
        /// BCURAB.
        /// </summary>
        public const string BCURAB = "BCURAB";

        /// <summary>
        /// BCURRF.
        /// </summary>
        public const string BCURRF = "BCURRF";

        /// <summary>
        /// BCUSER.
        /// </summary>
        public const string BCUSER = "BCUSER";

        /// <summary>
        /// BCPID.
        /// </summary>
        public const string BCPID = "BCPID";

        /// <summary>
        /// BCJOBN.
        /// </summary>
        public const string BCJOBN = "BCJOBN";

        /// <summary>
        /// BCUPMJ.
        /// </summary>
        public const string BCUPMJ = "BCUPMJ";

        /// <summary>
        /// BCTDAY.
        /// </summary>
        public const string BCTDAY = "BCTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F4957";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BCSHPN", "BCSHPN", JdeDataType.Numeric, null, true, true),
        new JdeField("BCVMCU", "BCVMCU", JdeDataType.String, 24),
        new JdeField("BCLDNM", "BCLDNM", JdeDataType.Numeric),
        new JdeField("BCTRPL", "BCTRPL", JdeDataType.Numeric),
        new JdeField("BCLDDT", "BCLDDT", JdeDataType.Numeric),
        new JdeField("BCLDTM", "BCLDTM", JdeDataType.Numeric),
        new JdeField("BCADDJ", "BCADDJ", JdeDataType.Numeric),
        new JdeField("BCADTM", "BCADTM", JdeDataType.Numeric),
        new JdeField("BCDLDT", "BCDLDT", JdeDataType.Numeric),
        new JdeField("BCDLTM", "BCDLTM", JdeDataType.Numeric),
        new JdeField("BCWGTS", "BCWGTS", JdeDataType.Numeric),
        new JdeField("BCWTUM", "BCWTUM", JdeDataType.String, 4),
        new JdeField("BCRLNO", "BCRLNO", JdeDataType.String, 26),
        new JdeField("BCCARS", "BCCARS", JdeDataType.Numeric),
        new JdeField("BCMOT", "BCMOT", JdeDataType.String, 6),
        new JdeField("BCURCD", "BCURCD", JdeDataType.String, 4),
        new JdeField("BCURDT", "BCURDT", JdeDataType.Numeric),
        new JdeField("BCURAT", "BCURAT", JdeDataType.Numeric),
        new JdeField("BCURAB", "BCURAB", JdeDataType.Numeric),
        new JdeField("BCURRF", "BCURRF", JdeDataType.String, 30),
        new JdeField("BCUSER", "BCUSER", JdeDataType.String, 20),
        new JdeField("BCPID", "BCPID", JdeDataType.String, 20),
        new JdeField("BCJOBN", "BCJOBN", JdeDataType.String, 20),
        new JdeField("BCUPMJ", "BCUPMJ", JdeDataType.Numeric),
        new JdeField("BCTDAY", "BCTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4957_0", "Primary Key on BCSHPN", new[] { "BCSHPN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4957_2", "Index on BCVMCU, BCLDNM, BCTRPL, BCSHPN", new[] { "BCVMCU", "BCLDNM", "BCTRPL", "BCSHPN" })
    };
}
