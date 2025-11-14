using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74W203 - .
/// </summary>
public class F74W203 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// K3DAFN.
        /// </summary>
        public const string K3DAFN = "K3DAFN";

        /// <summary>
        /// K3NXTC.
        /// </summary>
        public const string K3NXTC = "K3NXTC";

        /// <summary>
        /// K3DARN.
        /// </summary>
        public const string K3DARN = "K3DARN";

        /// <summary>
        /// K3DAER.
        /// </summary>
        public const string K3DAER = "K3DAER";

        /// <summary>
        /// K3PAAP.
        /// </summary>
        public const string K3PAAP = "K3PAAP";

        /// <summary>
        /// K3CRCD.
        /// </summary>
        public const string K3CRCD = "K3CRCD";

        /// <summary>
        /// K3CRR.
        /// </summary>
        public const string K3CRR = "K3CRR";

        /// <summary>
        /// K3ACR.
        /// </summary>
        public const string K3ACR = "K3ACR";

        /// <summary>
        /// K3EFTJ.
        /// </summary>
        public const string K3EFTJ = "K3EFTJ";

        /// <summary>
        /// K3N001.
        /// </summary>
        public const string K3N001 = "K3N001";

        /// <summary>
        /// K3HDC.
        /// </summary>
        public const string K3HDC = "K3HDC";

        /// <summary>
        /// K3CKC.
        /// </summary>
        public const string K3CKC = "K3CKC";

        /// <summary>
        /// K3RC.
        /// </summary>
        public const string K3RC = "K3RC";

        /// <summary>
        /// K3DOC.
        /// </summary>
        public const string K3DOC = "K3DOC";

        /// <summary>
        /// K3DCT.
        /// </summary>
        public const string K3DCT = "K3DCT";

        /// <summary>
        /// K3KCO.
        /// </summary>
        public const string K3KCO = "K3KCO";

        /// <summary>
        /// K3SFX.
        /// </summary>
        public const string K3SFX = "K3SFX";

        /// <summary>
        /// K3SFXE.
        /// </summary>
        public const string K3SFXE = "K3SFXE";

        /// <summary>
        /// K3APTA.
        /// </summary>
        public const string K3APTA = "K3APTA";
    }

    /// <inheritdoc />
    public override string TableName => "F74W203";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("K3DAFN", "K3DAFN", JdeDataType.String, 60, true, true),
        new JdeField("K3NXTC", "K3NXTC", JdeDataType.Numeric, null, true, true),
        new JdeField("K3DARN", "K3DARN", JdeDataType.Numeric, null, true, true),
        new JdeField("K3DAER", "K3DAER", JdeDataType.String, 4),
        new JdeField("K3PAAP", "K3PAAP", JdeDataType.Numeric),
        new JdeField("K3CRCD", "K3CRCD", JdeDataType.String, 6),
        new JdeField("K3CRR", "K3CRR", JdeDataType.Numeric),
        new JdeField("K3ACR", "K3ACR", JdeDataType.Numeric),
        new JdeField("K3EFTJ", "K3EFTJ", JdeDataType.Numeric),
        new JdeField("K3N001", "K3N001", JdeDataType.Numeric),
        new JdeField("K3HDC", "K3HDC", JdeDataType.Numeric),
        new JdeField("K3CKC", "K3CKC", JdeDataType.Numeric),
        new JdeField("K3RC", "K3RC", JdeDataType.String, 2),
        new JdeField("K3DOC", "K3DOC", JdeDataType.Numeric),
        new JdeField("K3DCT", "K3DCT", JdeDataType.String, 4),
        new JdeField("K3KCO", "K3KCO", JdeDataType.String, 10),
        new JdeField("K3SFX", "K3SFX", JdeDataType.String, 6),
        new JdeField("K3SFXE", "K3SFXE", JdeDataType.Numeric),
        new JdeField("K3APTA", "K3APTA", JdeDataType.String, 3000)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74W203_0", "Primary Key on K3DAFN, K3NXTC, K3DARN", new[] { "K3DAFN", "K3NXTC", "K3DARN" }, isUnique: true, isPrimaryKey: true)
    };
}
