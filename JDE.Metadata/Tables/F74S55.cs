using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74S55 - .
/// </summary>
public class F74S55 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Q5HDC.
        /// </summary>
        public const string Q5HDC = "Q5HDC";

        /// <summary>
        /// Q5CKC.
        /// </summary>
        public const string Q5CKC = "Q5CKC";

        /// <summary>
        /// Q5DOCM.
        /// </summary>
        public const string Q5DOCM = "Q5DOCM";

        /// <summary>
        /// Q5AN8.
        /// </summary>
        public const string Q5AN8 = "Q5AN8";

        /// <summary>
        /// Q5DCTM.
        /// </summary>
        public const string Q5DCTM = "Q5DCTM";

        /// <summary>
        /// Q5ICU.
        /// </summary>
        public const string Q5ICU = "Q5ICU";

        /// <summary>
        /// Q5LNID.
        /// </summary>
        public const string Q5LNID = "Q5LNID";

        /// <summary>
        /// Q5AID.
        /// </summary>
        public const string Q5AID = "Q5AID";

        /// <summary>
        /// Q5SBL.
        /// </summary>
        public const string Q5SBL = "Q5SBL";

        /// <summary>
        /// Q5SBLT.
        /// </summary>
        public const string Q5SBLT = "Q5SBLT";

        /// <summary>
        /// Q5AAP.
        /// </summary>
        public const string Q5AAP = "Q5AAP";

        /// <summary>
        /// Q5POST.
        /// </summary>
        public const string Q5POST = "Q5POST";

        /// <summary>
        /// Q5EXR.
        /// </summary>
        public const string Q5EXR = "Q5EXR";

        /// <summary>
        /// Q5CRR.
        /// </summary>
        public const string Q5CRR = "Q5CRR";

        /// <summary>
        /// Q5CRRM.
        /// </summary>
        public const string Q5CRRM = "Q5CRRM";

        /// <summary>
        /// Q5CRCD.
        /// </summary>
        public const string Q5CRCD = "Q5CRCD";

        /// <summary>
        /// Q5CRCX.
        /// </summary>
        public const string Q5CRCX = "Q5CRCX";

        /// <summary>
        /// Q5FAP.
        /// </summary>
        public const string Q5FAP = "Q5FAP";
    }

    /// <inheritdoc />
    public override string TableName => "F74S55";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Q5HDC", "Q5HDC", JdeDataType.Numeric, null, true, true),
        new JdeField("Q5CKC", "Q5CKC", JdeDataType.Numeric, null, true, true),
        new JdeField("Q5DOCM", "Q5DOCM", JdeDataType.Numeric, null, true, true),
        new JdeField("Q5AN8", "Q5AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("Q5DCTM", "Q5DCTM", JdeDataType.String, 4),
        new JdeField("Q5ICU", "Q5ICU", JdeDataType.Numeric),
        new JdeField("Q5LNID", "Q5LNID", JdeDataType.Numeric, null, true, true),
        new JdeField("Q5AID", "Q5AID", JdeDataType.String, 16),
        new JdeField("Q5SBL", "Q5SBL", JdeDataType.String, 16),
        new JdeField("Q5SBLT", "Q5SBLT", JdeDataType.String, 2),
        new JdeField("Q5AAP", "Q5AAP", JdeDataType.Numeric),
        new JdeField("Q5POST", "Q5POST", JdeDataType.String, 2),
        new JdeField("Q5EXR", "Q5EXR", JdeDataType.String, 60),
        new JdeField("Q5CRR", "Q5CRR", JdeDataType.Numeric),
        new JdeField("Q5CRRM", "Q5CRRM", JdeDataType.String, 2),
        new JdeField("Q5CRCD", "Q5CRCD", JdeDataType.String, 6),
        new JdeField("Q5CRCX", "Q5CRCX", JdeDataType.String, 6),
        new JdeField("Q5FAP", "Q5FAP", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74S55_0", "Primary Key on Q5HDC, Q5CKC, Q5AN8, Q5DOCM, Q5LNID", new[] { "Q5HDC", "Q5CKC", "Q5AN8", "Q5DOCM", "Q5LNID" }, isUnique: true, isPrimaryKey: true)
    };
}
