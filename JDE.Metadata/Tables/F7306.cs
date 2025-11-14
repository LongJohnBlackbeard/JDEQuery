using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F7306 - .
/// </summary>
public class F7306 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VQSY.
        /// </summary>
        public const string VQSY = "VQSY";

        /// <summary>
        /// VQVVTX.
        /// </summary>
        public const string VQVVTX = "VQVVTX";

        /// <summary>
        /// VQVVUS.
        /// </summary>
        public const string VQVVUS = "VQVVUS";

        /// <summary>
        /// VQVVCN.
        /// </summary>
        public const string VQVVCN = "VQVVCN";

        /// <summary>
        /// VQVVAB.
        /// </summary>
        public const string VQVVAB = "VQVVAB";

        /// <summary>
        /// VQVVIT.
        /// </summary>
        public const string VQVVIT = "VQVVIT";

        /// <summary>
        /// VQVUAB.
        /// </summary>
        public const string VQVUAB = "VQVUAB";

        /// <summary>
        /// VQVUIT.
        /// </summary>
        public const string VQVUIT = "VQVUIT";

        /// <summary>
        /// VQGL01.
        /// </summary>
        public const string VQGL01 = "VQGL01";

        /// <summary>
        /// VQVVMC.
        /// </summary>
        public const string VQVVMC = "VQVVMC";

        /// <summary>
        /// VQVPRT.
        /// </summary>
        public const string VQVPRT = "VQVPRT";

        /// <summary>
        /// VQVCCS.
        /// </summary>
        public const string VQVCCS = "VQVCCS";

        /// <summary>
        /// VQVCCU.
        /// </summary>
        public const string VQVCCU = "VQVCCU";

        /// <summary>
        /// VQQDLG.
        /// </summary>
        public const string VQQDLG = "VQQDLG";

        /// <summary>
        /// VQVCCF.
        /// </summary>
        public const string VQVCCF = "VQVCCF";
    }

    /// <inheritdoc />
    public override string TableName => "F7306";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VQSY", "VQSY", JdeDataType.String, 8, true, true),
        new JdeField("VQVVTX", "VQVVTX", JdeDataType.String, 2),
        new JdeField("VQVVUS", "VQVVUS", JdeDataType.String, 6),
        new JdeField("VQVVCN", "VQVVCN", JdeDataType.String, 6),
        new JdeField("VQVVAB", "VQVVAB", JdeDataType.String, 4),
        new JdeField("VQVVIT", "VQVVIT", JdeDataType.String, 8),
        new JdeField("VQVUAB", "VQVUAB", JdeDataType.String, 4),
        new JdeField("VQVUIT", "VQVUIT", JdeDataType.String, 8),
        new JdeField("VQGL01", "VQGL01", JdeDataType.String, 8),
        new JdeField("VQVVMC", "VQVVMC", JdeDataType.String, 2),
        new JdeField("VQVPRT", "VQVPRT", JdeDataType.String, 2),
        new JdeField("VQVCCS", "VQVCCS", JdeDataType.String, 4),
        new JdeField("VQVCCU", "VQVCCU", JdeDataType.String, 4),
        new JdeField("VQQDLG", "VQQDLG", JdeDataType.String, 160),
        new JdeField("VQVCCF", "VQVCCF", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F7306_0", "Primary Key on VQSY", new[] { "VQSY" }, isUnique: true, isPrimaryKey: true)
    };
}
