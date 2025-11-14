using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F7430010 - .
/// </summary>
public class F7430010 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LDKCO.
        /// </summary>
        public const string LDKCO = "LDKCO";

        /// <summary>
        /// LDDCT.
        /// </summary>
        public const string LDDCT = "LDDCT";

        /// <summary>
        /// LDDOC.
        /// </summary>
        public const string LDDOC = "LDDOC";

        /// <summary>
        /// LDK74LECO.
        /// </summary>
        public const string LDK74LECO = "LDK74LECO";

        /// <summary>
        /// LDK74LEDT.
        /// </summary>
        public const string LDK74LEDT = "LDK74LEDT";

        /// <summary>
        /// LDK74ISPL.
        /// </summary>
        public const string LDK74ISPL = "LDK74ISPL";

        /// <summary>
        /// LDK74LENU.
        /// </summary>
        public const string LDK74LENU = "LDK74LENU";

        /// <summary>
        /// LDAN8.
        /// </summary>
        public const string LDAN8 = "LDAN8";

        /// <summary>
        /// LDK74LDDJ.
        /// </summary>
        public const string LDK74LDDJ = "LDK74LDDJ";

        /// <summary>
        /// LDK74DPF.
        /// </summary>
        public const string LDK74DPF = "LDK74DPF";

        /// <summary>
        /// LDK74DPD.
        /// </summary>
        public const string LDK74DPD = "LDK74DPD";

        /// <summary>
        /// LDVOD.
        /// </summary>
        public const string LDVOD = "LDVOD";

        /// <summary>
        /// LDVDGJ.
        /// </summary>
        public const string LDVDGJ = "LDVDGJ";

        /// <summary>
        /// LDADDJ.
        /// </summary>
        public const string LDADDJ = "LDADDJ";

        /// <summary>
        /// LDAPV.
        /// </summary>
        public const string LDAPV = "LDAPV";

        /// <summary>
        /// LDK74PT.
        /// </summary>
        public const string LDK74PT = "LDK74PT";

        /// <summary>
        /// LDSY.
        /// </summary>
        public const string LDSY = "LDSY";

        /// <summary>
        /// LDTORG.
        /// </summary>
        public const string LDTORG = "LDTORG";

        /// <summary>
        /// LDUSER.
        /// </summary>
        public const string LDUSER = "LDUSER";

        /// <summary>
        /// LDPID.
        /// </summary>
        public const string LDPID = "LDPID";

        /// <summary>
        /// LDJOBN.
        /// </summary>
        public const string LDJOBN = "LDJOBN";

        /// <summary>
        /// LDUPMJ.
        /// </summary>
        public const string LDUPMJ = "LDUPMJ";

        /// <summary>
        /// LDUPMT.
        /// </summary>
        public const string LDUPMT = "LDUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F7430010";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LDKCO", "LDKCO", JdeDataType.String, 10, true, true),
        new JdeField("LDDCT", "LDDCT", JdeDataType.String, 4, true, true),
        new JdeField("LDDOC", "LDDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("LDK74LECO", "LDK74LECO", JdeDataType.String, 10),
        new JdeField("LDK74LEDT", "LDK74LEDT", JdeDataType.String, 10),
        new JdeField("LDK74ISPL", "LDK74ISPL", JdeDataType.String, 30),
        new JdeField("LDK74LENU", "LDK74LENU", JdeDataType.Numeric),
        new JdeField("LDAN8", "LDAN8", JdeDataType.Numeric),
        new JdeField("LDK74LDDJ", "LDK74LDDJ", JdeDataType.Numeric),
        new JdeField("LDK74DPF", "LDK74DPF", JdeDataType.String, 2),
        new JdeField("LDK74DPD", "LDK74DPD", JdeDataType.Numeric),
        new JdeField("LDVOD", "LDVOD", JdeDataType.String, 2),
        new JdeField("LDVDGJ", "LDVDGJ", JdeDataType.Numeric),
        new JdeField("LDADDJ", "LDADDJ", JdeDataType.Numeric),
        new JdeField("LDAPV", "LDAPV", JdeDataType.Numeric),
        new JdeField("LDK74PT", "LDK74PT", JdeDataType.Numeric),
        new JdeField("LDSY", "LDSY", JdeDataType.String, 8),
        new JdeField("LDTORG", "LDTORG", JdeDataType.String, 20),
        new JdeField("LDUSER", "LDUSER", JdeDataType.String, 20),
        new JdeField("LDPID", "LDPID", JdeDataType.String, 20),
        new JdeField("LDJOBN", "LDJOBN", JdeDataType.String, 20),
        new JdeField("LDUPMJ", "LDUPMJ", JdeDataType.Numeric),
        new JdeField("LDUPMT", "LDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F7430010_0", "Primary Key on LDKCO, LDDCT, LDDOC", new[] { "LDKCO", "LDDCT", "LDDOC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F7430010_2", "Index on LDK74LECO, LDK74LEDT, LDK74ISPL, LDK74LENU", new[] { "LDK74LECO", "LDK74LEDT", "LDK74ISPL", "LDK74LENU" })
    };
}
