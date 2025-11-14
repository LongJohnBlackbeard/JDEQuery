using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FD3N913 - .
/// </summary>
public class FD3N913 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DLFMAT.
        /// </summary>
        public const string DLFMAT = "DLFMAT";

        /// <summary>
        /// DLYN.
        /// </summary>
        public const string DLYN = "DLYN";

        /// <summary>
        /// DLBLCT.
        /// </summary>
        public const string DLBLCT = "DLBLCT";

        /// <summary>
        /// DLPFN0.
        /// </summary>
        public const string DLPFN0 = "DLPFN0";

        /// <summary>
        /// DLTRPK.
        /// </summary>
        public const string DLTRPK = "DLTRPK";

        /// <summary>
        /// DLAN8.
        /// </summary>
        public const string DLAN8 = "DLAN8";

        /// <summary>
        /// DLITM.
        /// </summary>
        public const string DLITM = "DLITM";

        /// <summary>
        /// DLSHAN.
        /// </summary>
        public const string DLSHAN = "DLSHAN";

        /// <summary>
        /// DLMCU.
        /// </summary>
        public const string DLMCU = "DLMCU";

        /// <summary>
        /// DLUOM.
        /// </summary>
        public const string DLUOM = "DLUOM";

        /// <summary>
        /// DLPID.
        /// </summary>
        public const string DLPID = "DLPID";
    }

    /// <inheritdoc />
    public override string TableName => "FD3N913";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DLFMAT", "DLFMAT", JdeDataType.String, 20),
        new JdeField("DLYN", "DLYN", JdeDataType.String, 2),
        new JdeField("DLBLCT", "DLBLCT", JdeDataType.Numeric),
        new JdeField("DLPFN0", "DLPFN0", JdeDataType.Numeric),
        new JdeField("DLTRPK", "DLTRPK", JdeDataType.String, 2, true, true),
        new JdeField("DLAN8", "DLAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("DLITM", "DLITM", JdeDataType.Numeric, null, true, true),
        new JdeField("DLSHAN", "DLSHAN", JdeDataType.Numeric, null, true, true),
        new JdeField("DLMCU", "DLMCU", JdeDataType.String, 24, true, true),
        new JdeField("DLUOM", "DLUOM", JdeDataType.String, 4, true, true),
        new JdeField("DLPID", "DLPID", JdeDataType.String, 20, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FD3N913_0", "Primary Key on DLTRPK, DLAN8, DLITM, DLSHAN, DLMCU, DLUOM, DLPID", new[] { "DLTRPK", "DLAN8", "DLITM", "DLSHAN", "DLMCU", "DLUOM", "DLPID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FD3N913_2", "Index on DLITM, DLUOM, DLAN8, DLMCU", new[] { "DLITM", "DLUOM", "DLAN8", "DLMCU" })
    };
}
