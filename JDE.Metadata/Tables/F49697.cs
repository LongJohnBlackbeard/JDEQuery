using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49697 - .
/// </summary>
public class F49697 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DNCO.
        /// </summary>
        public const string DNCO = "DNCO";

        /// <summary>
        /// DNEMCU.
        /// </summary>
        public const string DNEMCU = "DNEMCU";

        /// <summary>
        /// DNMCU.
        /// </summary>
        public const string DNMCU = "DNMCU";

        /// <summary>
        /// DNDCT.
        /// </summary>
        public const string DNDCT = "DNDCT";

        /// <summary>
        /// DNDOC.
        /// </summary>
        public const string DNDOC = "DNDOC";

        /// <summary>
        /// DNKCO.
        /// </summary>
        public const string DNKCO = "DNKCO";

        /// <summary>
        /// DNDTDO.
        /// </summary>
        public const string DNDTDO = "DNDTDO";

        /// <summary>
        /// DNDCCD.
        /// </summary>
        public const string DNDCCD = "DNDCCD";

        /// <summary>
        /// DNVMCU.
        /// </summary>
        public const string DNVMCU = "DNVMCU";

        /// <summary>
        /// DNSHAN.
        /// </summary>
        public const string DNSHAN = "DNSHAN";

        /// <summary>
        /// DNLDNM.
        /// </summary>
        public const string DNLDNM = "DNLDNM";

        /// <summary>
        /// DNTRPL.
        /// </summary>
        public const string DNTRPL = "DNTRPL";

        /// <summary>
        /// DNSHPN.
        /// </summary>
        public const string DNSHPN = "DNSHPN";

        /// <summary>
        /// DNRSSN.
        /// </summary>
        public const string DNRSSN = "DNRSSN";

        /// <summary>
        /// DNURCD.
        /// </summary>
        public const string DNURCD = "DNURCD";

        /// <summary>
        /// DNURDT.
        /// </summary>
        public const string DNURDT = "DNURDT";

        /// <summary>
        /// DNURAT.
        /// </summary>
        public const string DNURAT = "DNURAT";

        /// <summary>
        /// DNURAB.
        /// </summary>
        public const string DNURAB = "DNURAB";

        /// <summary>
        /// DNURRF.
        /// </summary>
        public const string DNURRF = "DNURRF";

        /// <summary>
        /// DNUSER.
        /// </summary>
        public const string DNUSER = "DNUSER";

        /// <summary>
        /// DNPID.
        /// </summary>
        public const string DNPID = "DNPID";

        /// <summary>
        /// DNJOBN.
        /// </summary>
        public const string DNJOBN = "DNJOBN";

        /// <summary>
        /// DNUPMJ.
        /// </summary>
        public const string DNUPMJ = "DNUPMJ";

        /// <summary>
        /// DNTDAY.
        /// </summary>
        public const string DNTDAY = "DNTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F49697";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DNCO", "DNCO", JdeDataType.String, 10, true, true),
        new JdeField("DNEMCU", "DNEMCU", JdeDataType.String, 24, true, true),
        new JdeField("DNMCU", "DNMCU", JdeDataType.String, 24, true, true),
        new JdeField("DNDCT", "DNDCT", JdeDataType.String, 4, true, true),
        new JdeField("DNDOC", "DNDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("DNKCO", "DNKCO", JdeDataType.String, 10, true, true),
        new JdeField("DNDTDO", "DNDTDO", JdeDataType.Numeric),
        new JdeField("DNDCCD", "DNDCCD", JdeDataType.String, 8),
        new JdeField("DNVMCU", "DNVMCU", JdeDataType.String, 24),
        new JdeField("DNSHAN", "DNSHAN", JdeDataType.Numeric, null, true, true),
        new JdeField("DNLDNM", "DNLDNM", JdeDataType.Numeric),
        new JdeField("DNTRPL", "DNTRPL", JdeDataType.Numeric),
        new JdeField("DNSHPN", "DNSHPN", JdeDataType.Numeric),
        new JdeField("DNRSSN", "DNRSSN", JdeDataType.Numeric),
        new JdeField("DNURCD", "DNURCD", JdeDataType.String, 4),
        new JdeField("DNURDT", "DNURDT", JdeDataType.Numeric),
        new JdeField("DNURAT", "DNURAT", JdeDataType.Numeric),
        new JdeField("DNURAB", "DNURAB", JdeDataType.Numeric),
        new JdeField("DNURRF", "DNURRF", JdeDataType.String, 30),
        new JdeField("DNUSER", "DNUSER", JdeDataType.String, 20),
        new JdeField("DNPID", "DNPID", JdeDataType.String, 20),
        new JdeField("DNJOBN", "DNJOBN", JdeDataType.String, 20),
        new JdeField("DNUPMJ", "DNUPMJ", JdeDataType.Numeric),
        new JdeField("DNTDAY", "DNTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49697_0", "Primary Key on DNCO, DNEMCU, DNMCU, DNDCT, DNDOC, DNKCO, DNSHAN", new[] { "DNCO", "DNEMCU", "DNMCU", "DNDCT", "DNDOC", "DNKCO", "DNSHAN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F49697_2", "Index on DNDCCD, DNVMCU, DNLDNM", new[] { "DNDCCD", "DNVMCU", "DNLDNM" }),
        new JdeIndex("F49697_3", "Index on DNDCCD, DNSHPN, DNRSSN", new[] { "DNDCCD", "DNSHPN", "DNRSSN" })
    };
}
