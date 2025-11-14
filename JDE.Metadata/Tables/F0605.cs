using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0605 - .
/// </summary>
public class F0605 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// J_1AN8.
        /// </summary>
        public const string J_1AN8 = "J_1AN8";

        /// <summary>
        /// J_1PDBA.
        /// </summary>
        public const string J_1PDBA = "J_1PDBA";

        /// <summary>
        /// J_1PCNO.
        /// </summary>
        public const string J_1PCNO = "J_1PCNO";

        /// <summary>
        /// J_1DTEY.
        /// </summary>
        public const string J_1DTEY = "J_1DTEY";

        /// <summary>
        /// J_1HMO.
        /// </summary>
        public const string J_1HMO = "J_1HMO";

        /// <summary>
        /// J_1TAXX.
        /// </summary>
        public const string J_1TAXX = "J_1TAXX";

        /// <summary>
        /// J_1HMCO.
        /// </summary>
        public const string J_1HMCO = "J_1HMCO";

        /// <summary>
        /// J_1DEP1.
        /// </summary>
        public const string J_1DEP1 = "J_1DEP1";

        /// <summary>
        /// J_1DEP2.
        /// </summary>
        public const string J_1DEP2 = "J_1DEP2";

        /// <summary>
        /// J_1DEP3.
        /// </summary>
        public const string J_1DEP3 = "J_1DEP3";

        /// <summary>
        /// J_1DEP4.
        /// </summary>
        public const string J_1DEP4 = "J_1DEP4";

        /// <summary>
        /// J_1DEP5.
        /// </summary>
        public const string J_1DEP5 = "J_1DEP5";

        /// <summary>
        /// J_1GPA1.
        /// </summary>
        public const string J_1GPA1 = "J_1GPA1";

        /// <summary>
        /// J_1GPA2.
        /// </summary>
        public const string J_1GPA2 = "J_1GPA2";

        /// <summary>
        /// J_1GPA3.
        /// </summary>
        public const string J_1GPA3 = "J_1GPA3";

        /// <summary>
        /// J_1GPA4.
        /// </summary>
        public const string J_1GPA4 = "J_1GPA4";

        /// <summary>
        /// J_1GPA5.
        /// </summary>
        public const string J_1GPA5 = "J_1GPA5";

        /// <summary>
        /// J_1CKC1.
        /// </summary>
        public const string J_1CKC1 = "J_1CKC1";

        /// <summary>
        /// J_1CKC2.
        /// </summary>
        public const string J_1CKC2 = "J_1CKC2";

        /// <summary>
        /// J_1CKC3.
        /// </summary>
        public const string J_1CKC3 = "J_1CKC3";

        /// <summary>
        /// J_1CKC4.
        /// </summary>
        public const string J_1CKC4 = "J_1CKC4";

        /// <summary>
        /// J_1CKC5.
        /// </summary>
        public const string J_1CKC5 = "J_1CKC5";

        /// <summary>
        /// J_1RTA1.
        /// </summary>
        public const string J_1RTA1 = "J_1RTA1";

        /// <summary>
        /// J_1RTA2.
        /// </summary>
        public const string J_1RTA2 = "J_1RTA2";

        /// <summary>
        /// J_1RTA3.
        /// </summary>
        public const string J_1RTA3 = "J_1RTA3";

        /// <summary>
        /// J_1RTA4.
        /// </summary>
        public const string J_1RTA4 = "J_1RTA4";

        /// <summary>
        /// J_1RTA5.
        /// </summary>
        public const string J_1RTA5 = "J_1RTA5";
    }

    /// <inheritdoc />
    public override string TableName => "F0605";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("J_1AN8", "J_1AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("J_1PDBA", "J_1PDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("J_1PCNO", "J_1PCNO", JdeDataType.Numeric, null, true, true),
        new JdeField("J_1DTEY", "J_1DTEY", JdeDataType.Numeric, null, true, true),
        new JdeField("J_1HMO", "J_1HMO", JdeDataType.Numeric, null, true, true),
        new JdeField("J_1TAXX", "J_1TAXX", JdeDataType.String, 40, true, true),
        new JdeField("J_1HMCO", "J_1HMCO", JdeDataType.String, 10, true, true),
        new JdeField("J_1DEP1", "J_1DEP1", JdeDataType.String, 2),
        new JdeField("J_1DEP2", "J_1DEP2", JdeDataType.String, 2),
        new JdeField("J_1DEP3", "J_1DEP3", JdeDataType.String, 2),
        new JdeField("J_1DEP4", "J_1DEP4", JdeDataType.String, 2),
        new JdeField("J_1DEP5", "J_1DEP5", JdeDataType.String, 2),
        new JdeField("J_1GPA1", "J_1GPA1", JdeDataType.Numeric),
        new JdeField("J_1GPA2", "J_1GPA2", JdeDataType.Numeric),
        new JdeField("J_1GPA3", "J_1GPA3", JdeDataType.Numeric),
        new JdeField("J_1GPA4", "J_1GPA4", JdeDataType.Numeric),
        new JdeField("J_1GPA5", "J_1GPA5", JdeDataType.Numeric),
        new JdeField("J_1CKC1", "J_1CKC1", JdeDataType.Numeric),
        new JdeField("J_1CKC2", "J_1CKC2", JdeDataType.Numeric),
        new JdeField("J_1CKC3", "J_1CKC3", JdeDataType.Numeric),
        new JdeField("J_1CKC4", "J_1CKC4", JdeDataType.Numeric),
        new JdeField("J_1CKC5", "J_1CKC5", JdeDataType.Numeric),
        new JdeField("J_1RTA1", "J_1RTA1", JdeDataType.Numeric),
        new JdeField("J_1RTA2", "J_1RTA2", JdeDataType.Numeric),
        new JdeField("J_1RTA3", "J_1RTA3", JdeDataType.Numeric),
        new JdeField("J_1RTA4", "J_1RTA4", JdeDataType.Numeric),
        new JdeField("J_1RTA5", "J_1RTA5", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0605_0", "Primary Key on J_1AN8, J_1PDBA, J_1PCNO, J_1DTEY, J_1HMO, J_1TAXX, J_1HMCO", new[] { "J_1AN8", "J_1PDBA", "J_1PCNO", "J_1DTEY", "J_1HMO", "J_1TAXX", "J_1HMCO" }, isUnique: true, isPrimaryKey: true)
    };
}
