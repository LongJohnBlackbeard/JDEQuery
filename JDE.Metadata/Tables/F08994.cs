using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08994 - .
/// </summary>
public class F08994 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// H1PAN8.
        /// </summary>
        public const string H1PAN8 = "H1PAN8";

        /// <summary>
        /// H1QE1.
        /// </summary>
        public const string H1QE1 = "H1QE1";

        /// <summary>
        /// H1QD1.
        /// </summary>
        public const string H1QD1 = "H1QD1";

        /// <summary>
        /// H1CBCK.
        /// </summary>
        public const string H1CBCK = "H1CBCK";

        /// <summary>
        /// H1CKAMT.
        /// </summary>
        public const string H1CKAMT = "H1CKAMT";

        /// <summary>
        /// H1ACC.
        /// </summary>
        public const string H1ACC = "H1ACC";

        /// <summary>
        /// H1TNST.
        /// </summary>
        public const string H1TNST = "H1TNST";

        /// <summary>
        /// H1CBCKDT.
        /// </summary>
        public const string H1CBCKDT = "H1CBCKDT";

        /// <summary>
        /// H1CBCKAD.
        /// </summary>
        public const string H1CBCKAD = "H1CBCKAD";

        /// <summary>
        /// H1CBCKS.
        /// </summary>
        public const string H1CBCKS = "H1CBCKS";

        /// <summary>
        /// H1MATH01.
        /// </summary>
        public const string H1MATH01 = "H1MATH01";

        /// <summary>
        /// H1CHAR101.
        /// </summary>
        public const string H1CHAR101 = "H1CHAR101";

        /// <summary>
        /// H1DATE01.
        /// </summary>
        public const string H1DATE01 = "H1DATE01";

        /// <summary>
        /// H1DL01.
        /// </summary>
        public const string H1DL01 = "H1DL01";

        /// <summary>
        /// H1USER.
        /// </summary>
        public const string H1USER = "H1USER";

        /// <summary>
        /// H1PID.
        /// </summary>
        public const string H1PID = "H1PID";

        /// <summary>
        /// H1JOBN.
        /// </summary>
        public const string H1JOBN = "H1JOBN";

        /// <summary>
        /// H1UPMJ.
        /// </summary>
        public const string H1UPMJ = "H1UPMJ";

        /// <summary>
        /// H1UPMT.
        /// </summary>
        public const string H1UPMT = "H1UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F08994";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("H1PAN8", "H1PAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("H1QE1", "H1QE1", JdeDataType.String, 4, true, true),
        new JdeField("H1QD1", "H1QD1", JdeDataType.Numeric, null, true, true),
        new JdeField("H1CBCK", "H1CBCK", JdeDataType.Numeric, null, true, true),
        new JdeField("H1CKAMT", "H1CKAMT", JdeDataType.Numeric),
        new JdeField("H1ACC", "H1ACC", JdeDataType.String, 32),
        new JdeField("H1TNST", "H1TNST", JdeDataType.String, 40),
        new JdeField("H1CBCKDT", "H1CBCKDT", JdeDataType.Numeric),
        new JdeField("H1CBCKAD", "H1CBCKAD", JdeDataType.Numeric),
        new JdeField("H1CBCKS", "H1CBCKS", JdeDataType.String, 6, true, true),
        new JdeField("H1MATH01", "H1MATH01", JdeDataType.Numeric),
        new JdeField("H1CHAR101", "H1CHAR101", JdeDataType.String, 20),
        new JdeField("H1DATE01", "H1DATE01", JdeDataType.Numeric),
        new JdeField("H1DL01", "H1DL01", JdeDataType.String, 60),
        new JdeField("H1USER", "H1USER", JdeDataType.String, 20),
        new JdeField("H1PID", "H1PID", JdeDataType.String, 20),
        new JdeField("H1JOBN", "H1JOBN", JdeDataType.String, 20),
        new JdeField("H1UPMJ", "H1UPMJ", JdeDataType.Numeric),
        new JdeField("H1UPMT", "H1UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08994_0", "Primary Key on H1PAN8, H1QE1, H1QD1, H1CBCK, H1CBCKS", new[] { "H1PAN8", "H1QE1", "H1QD1", "H1CBCK", "H1CBCKS" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08994_2", "Index on H1PAN8, H1QE1, H1QD1, H1CBCK", new[] { "H1PAN8", "H1QE1", "H1QD1", "H1CBCK" })
    };
}
