using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW59 - .
/// </summary>
public class FCW59 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WFITM.
        /// </summary>
        public const string WFITM = "WFITM";

        /// <summary>
        /// WFEV01.
        /// </summary>
        public const string WFEV01 = "WFEV01";

        /// <summary>
        /// WFPDGR.
        /// </summary>
        public const string WFPDGR = "WFPDGR";

        /// <summary>
        /// WFRTOB.
        /// </summary>
        public const string WFRTOB = "WFRTOB";

        /// <summary>
        /// WFRQTC.
        /// </summary>
        public const string WFRQTC = "WFRQTC";

        /// <summary>
        /// WFDNTB.
        /// </summary>
        public const string WFDNTB = "WFDNTB";

        /// <summary>
        /// WFSTCN.
        /// </summary>
        public const string WFSTCN = "WFSTCN";

        /// <summary>
        /// WFRPTM.
        /// </summary>
        public const string WFRPTM = "WFRPTM";

        /// <summary>
        /// WFDNTY.
        /// </summary>
        public const string WFDNTY = "WFDNTY";

        /// <summary>
        /// WFDNTP.
        /// </summary>
        public const string WFDNTP = "WFDNTP";

        /// <summary>
        /// WFDETP.
        /// </summary>
        public const string WFDETP = "WFDETP";

        /// <summary>
        /// WFDTPU.
        /// </summary>
        public const string WFDTPU = "WFDTPU";

        /// <summary>
        /// WFDSMN.
        /// </summary>
        public const string WFDSMN = "WFDSMN";

        /// <summary>
        /// WFDNTM.
        /// </summary>
        public const string WFDNTM = "WFDNTM";

        /// <summary>
        /// WFDNMX.
        /// </summary>
        public const string WFDNMX = "WFDNMX";

        /// <summary>
        /// WFDNTX.
        /// </summary>
        public const string WFDNTX = "WFDNTX";

        /// <summary>
        /// WFTMMN.
        /// </summary>
        public const string WFTMMN = "WFTMMN";

        /// <summary>
        /// WFTPUM.
        /// </summary>
        public const string WFTPUM = "WFTPUM";

        /// <summary>
        /// WFTMMX.
        /// </summary>
        public const string WFTMMX = "WFTMMX";

        /// <summary>
        /// WFTPUX.
        /// </summary>
        public const string WFTPUX = "WFTPUX";

        /// <summary>
        /// WFLPGP.
        /// </summary>
        public const string WFLPGP = "WFLPGP";

        /// <summary>
        /// WFCAVP.
        /// </summary>
        public const string WFCAVP = "WFCAVP";

        /// <summary>
        /// WFLPGV.
        /// </summary>
        public const string WFLPGV = "WFLPGV";

        /// <summary>
        /// WFTPU1.
        /// </summary>
        public const string WFTPU1 = "WFTPU1";

        /// <summary>
        /// WFCOEX.
        /// </summary>
        public const string WFCOEX = "WFCOEX";

        /// <summary>
        /// WFMNVC.
        /// </summary>
        public const string WFMNVC = "WFMNVC";

        /// <summary>
        /// WFMXVC.
        /// </summary>
        public const string WFMXVC = "WFMXVC";
    }

    /// <inheritdoc />
    public override string TableName => "FCW59";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WFITM", "WFITM", JdeDataType.Numeric, null, true, true),
        new JdeField("WFEV01", "WFEV01", JdeDataType.String, 2, true, true),
        new JdeField("WFPDGR", "WFPDGR", JdeDataType.String, 6),
        new JdeField("WFRTOB", "WFRTOB", JdeDataType.String, 2),
        new JdeField("WFRQTC", "WFRQTC", JdeDataType.String, 2),
        new JdeField("WFDNTB", "WFDNTB", JdeDataType.String, 8),
        new JdeField("WFSTCN", "WFSTCN", JdeDataType.String, 8),
        new JdeField("WFRPTM", "WFRPTM", JdeDataType.String, 8),
        new JdeField("WFDNTY", "WFDNTY", JdeDataType.Numeric),
        new JdeField("WFDNTP", "WFDNTP", JdeDataType.String, 2),
        new JdeField("WFDETP", "WFDETP", JdeDataType.Numeric),
        new JdeField("WFDTPU", "WFDTPU", JdeDataType.String, 2),
        new JdeField("WFDSMN", "WFDSMN", JdeDataType.Numeric),
        new JdeField("WFDNTM", "WFDNTM", JdeDataType.String, 2),
        new JdeField("WFDNMX", "WFDNMX", JdeDataType.Numeric),
        new JdeField("WFDNTX", "WFDNTX", JdeDataType.String, 2),
        new JdeField("WFTMMN", "WFTMMN", JdeDataType.Numeric),
        new JdeField("WFTPUM", "WFTPUM", JdeDataType.String, 2),
        new JdeField("WFTMMX", "WFTMMX", JdeDataType.Numeric),
        new JdeField("WFTPUX", "WFTPUX", JdeDataType.String, 2),
        new JdeField("WFLPGP", "WFLPGP", JdeDataType.String, 2),
        new JdeField("WFCAVP", "WFCAVP", JdeDataType.String, 2),
        new JdeField("WFLPGV", "WFLPGV", JdeDataType.Numeric),
        new JdeField("WFTPU1", "WFTPU1", JdeDataType.String, 2),
        new JdeField("WFCOEX", "WFCOEX", JdeDataType.Numeric),
        new JdeField("WFMNVC", "WFMNVC", JdeDataType.Numeric),
        new JdeField("WFMXVC", "WFMXVC", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW59_0", "Primary Key on WFITM, WFEV01", new[] { "WFITM", "WFEV01" }, isUnique: true, isPrimaryKey: true)
    };
}
