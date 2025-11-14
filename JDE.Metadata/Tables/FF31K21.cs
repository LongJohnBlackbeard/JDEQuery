using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF31K21 - .
/// </summary>
public class FF31K21 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CPFSCID.
        /// </summary>
        public const string CPFSCID = "CPFSCID";

        /// <summary>
        /// CPDFMCU.
        /// </summary>
        public const string CPDFMCU = "CPDFMCU";

        /// <summary>
        /// CPPMAPID.
        /// </summary>
        public const string CPPMAPID = "CPPMAPID";

        /// <summary>
        /// CPCMITM.
        /// </summary>
        public const string CPCMITM = "CPCMITM";

        /// <summary>
        /// CPBOSTR.
        /// </summary>
        public const string CPBOSTR = "CPBOSTR";

        /// <summary>
        /// CPPCODE.
        /// </summary>
        public const string CPPCODE = "CPPCODE";

        /// <summary>
        /// CPDFKPC.
        /// </summary>
        public const string CPDFKPC = "CPDFKPC";

        /// <summary>
        /// CPPCDQTY.
        /// </summary>
        public const string CPPCDQTY = "CPPCDQTY";

        /// <summary>
        /// CPTORG.
        /// </summary>
        public const string CPTORG = "CPTORG";

        /// <summary>
        /// CPUSER.
        /// </summary>
        public const string CPUSER = "CPUSER";

        /// <summary>
        /// CPJOBN.
        /// </summary>
        public const string CPJOBN = "CPJOBN";

        /// <summary>
        /// CPPID.
        /// </summary>
        public const string CPPID = "CPPID";

        /// <summary>
        /// CPURCD.
        /// </summary>
        public const string CPURCD = "CPURCD";

        /// <summary>
        /// CPURDT.
        /// </summary>
        public const string CPURDT = "CPURDT";

        /// <summary>
        /// CPURAT.
        /// </summary>
        public const string CPURAT = "CPURAT";

        /// <summary>
        /// CPURAB.
        /// </summary>
        public const string CPURAB = "CPURAB";

        /// <summary>
        /// CPURRF.
        /// </summary>
        public const string CPURRF = "CPURRF";

        /// <summary>
        /// CPUUPMJ.
        /// </summary>
        public const string CPUUPMJ = "CPUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "FF31K21";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CPFSCID", "CPFSCID", JdeDataType.Numeric, null, true, true),
        new JdeField("CPDFMCU", "CPDFMCU", JdeDataType.String, 24, true, true),
        new JdeField("CPPMAPID", "CPPMAPID", JdeDataType.Numeric, null, true, true),
        new JdeField("CPCMITM", "CPCMITM", JdeDataType.Numeric, null, true, true),
        new JdeField("CPBOSTR", "CPBOSTR", JdeDataType.String, 8, true, true),
        new JdeField("CPPCODE", "CPPCODE", JdeDataType.String, 4),
        new JdeField("CPDFKPC", "CPDFKPC", JdeDataType.String, 60, true, true),
        new JdeField("CPPCDQTY", "CPPCDQTY", JdeDataType.Numeric),
        new JdeField("CPTORG", "CPTORG", JdeDataType.String, 20),
        new JdeField("CPUSER", "CPUSER", JdeDataType.String, 20),
        new JdeField("CPJOBN", "CPJOBN", JdeDataType.String, 20),
        new JdeField("CPPID", "CPPID", JdeDataType.String, 20),
        new JdeField("CPURCD", "CPURCD", JdeDataType.String, 4),
        new JdeField("CPURDT", "CPURDT", JdeDataType.Numeric),
        new JdeField("CPURAT", "CPURAT", JdeDataType.Numeric),
        new JdeField("CPURAB", "CPURAB", JdeDataType.Numeric),
        new JdeField("CPURRF", "CPURRF", JdeDataType.String, 30),
        new JdeField("CPUUPMJ", "CPUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF31K21_0", "Primary Key on CPFSCID, CPDFMCU, CPPMAPID, CPCMITM, CPBOSTR, CPDFKPC", new[] { "CPFSCID", "CPDFMCU", "CPPMAPID", "CPCMITM", "CPBOSTR", "CPDFKPC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF31K21_2", "Index on CPFSCID, CPDFMCU, CPCMITM", new[] { "CPFSCID", "CPDFMCU", "CPCMITM" }),
        new JdeIndex("FF31K21_3", "Index on CPFSCID, CPDFKPC", new[] { "CPFSCID", "CPDFKPC" })
    };
}
