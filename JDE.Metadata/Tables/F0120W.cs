using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0120W - .
/// </summary>
public class F0120W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LPLSID.
        /// </summary>
        public const string LPLSID = "LPLSID";

        /// <summary>
        /// LPAN8.
        /// </summary>
        public const string LPAN8 = "LPAN8";

        /// <summary>
        /// LPALPH.
        /// </summary>
        public const string LPALPH = "LPALPH";

        /// <summary>
        /// LPLATT.
        /// </summary>
        public const string LPLATT = "LPLATT";

        /// <summary>
        /// LPLONG.
        /// </summary>
        public const string LPLONG = "LPLONG";

        /// <summary>
        /// LPADD1.
        /// </summary>
        public const string LPADD1 = "LPADD1";

        /// <summary>
        /// LPADD2.
        /// </summary>
        public const string LPADD2 = "LPADD2";

        /// <summary>
        /// LPADD3.
        /// </summary>
        public const string LPADD3 = "LPADD3";

        /// <summary>
        /// LPADD4.
        /// </summary>
        public const string LPADD4 = "LPADD4";

        /// <summary>
        /// LPCTY1.
        /// </summary>
        public const string LPCTY1 = "LPCTY1";

        /// <summary>
        /// LPADDS.
        /// </summary>
        public const string LPADDS = "LPADDS";

        /// <summary>
        /// LPADDZ.
        /// </summary>
        public const string LPADDZ = "LPADDZ";

        /// <summary>
        /// LPCOUN.
        /// </summary>
        public const string LPCOUN = "LPCOUN";

        /// <summary>
        /// LPCTR.
        /// </summary>
        public const string LPCTR = "LPCTR";

        /// <summary>
        /// LPLPROX.
        /// </summary>
        public const string LPLPROX = "LPLPROX";
    }

    /// <inheritdoc />
    public override string TableName => "F0120W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LPLSID", "LPLSID", JdeDataType.String, 200, true, true),
        new JdeField("LPAN8", "LPAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("LPALPH", "LPALPH", JdeDataType.String, 80),
        new JdeField("LPLATT", "LPLATT", JdeDataType.String, 50),
        new JdeField("LPLONG", "LPLONG", JdeDataType.String, 50),
        new JdeField("LPADD1", "LPADD1", JdeDataType.String, 80),
        new JdeField("LPADD2", "LPADD2", JdeDataType.String, 80),
        new JdeField("LPADD3", "LPADD3", JdeDataType.String, 80),
        new JdeField("LPADD4", "LPADD4", JdeDataType.String, 80),
        new JdeField("LPCTY1", "LPCTY1", JdeDataType.String, 50),
        new JdeField("LPADDS", "LPADDS", JdeDataType.String, 6),
        new JdeField("LPADDZ", "LPADDZ", JdeDataType.String, 24),
        new JdeField("LPCOUN", "LPCOUN", JdeDataType.String, 50),
        new JdeField("LPCTR", "LPCTR", JdeDataType.String, 6),
        new JdeField("LPLPROX", "LPLPROX", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0120W_0", "Primary Key on LPLSID, LPAN8", new[] { "LPLSID", "LPAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
