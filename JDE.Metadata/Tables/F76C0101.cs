using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76C0101 - .
/// </summary>
public class F76C0101 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// V0AN8.
        /// </summary>
        public const string V0AN8 = "V0AN8";

        /// <summary>
        /// V076CTPT.
        /// </summary>
        public const string V076CTPT = "V076CTPT";

        /// <summary>
        /// V076CAEC.
        /// </summary>
        public const string V076CAEC = "V076CAEC";

        /// <summary>
        /// V076CTAXC.
        /// </summary>
        public const string V076CTAXC = "V076CTAXC";

        /// <summary>
        /// V076CTAX.
        /// </summary>
        public const string V076CTAX = "V076CTAX";

        /// <summary>
        /// V0EFTJ.
        /// </summary>
        public const string V0EFTJ = "V0EFTJ";

        /// <summary>
        /// V0EFDJ.
        /// </summary>
        public const string V0EFDJ = "V0EFDJ";

        /// <summary>
        /// V076CCIIU.
        /// </summary>
        public const string V076CCIIU = "V076CCIIU";

        /// <summary>
        /// V076CAC01.
        /// </summary>
        public const string V076CAC01 = "V076CAC01";

        /// <summary>
        /// V076CAC02.
        /// </summary>
        public const string V076CAC02 = "V076CAC02";

        /// <summary>
        /// V076CAC03.
        /// </summary>
        public const string V076CAC03 = "V076CAC03";

        /// <summary>
        /// V0URAB.
        /// </summary>
        public const string V0URAB = "V0URAB";

        /// <summary>
        /// V0URDT.
        /// </summary>
        public const string V0URDT = "V0URDT";

        /// <summary>
        /// V0URC1.
        /// </summary>
        public const string V0URC1 = "V0URC1";

        /// <summary>
        /// V0URRF.
        /// </summary>
        public const string V0URRF = "V0URRF";

        /// <summary>
        /// V0USER.
        /// </summary>
        public const string V0USER = "V0USER";

        /// <summary>
        /// V0PID.
        /// </summary>
        public const string V0PID = "V0PID";

        /// <summary>
        /// V0JOBN.
        /// </summary>
        public const string V0JOBN = "V0JOBN";

        /// <summary>
        /// V0UPMJ.
        /// </summary>
        public const string V0UPMJ = "V0UPMJ";

        /// <summary>
        /// V0UPMT.
        /// </summary>
        public const string V0UPMT = "V0UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76C0101";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("V0AN8", "V0AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("V076CTPT", "V076CTPT", JdeDataType.String, 2),
        new JdeField("V076CAEC", "V076CAEC", JdeDataType.String, 6),
        new JdeField("V076CTAXC", "V076CTAXC", JdeDataType.String, 2),
        new JdeField("V076CTAX", "V076CTAX", JdeDataType.String, 40),
        new JdeField("V0EFTJ", "V0EFTJ", JdeDataType.Numeric),
        new JdeField("V0EFDJ", "V0EFDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("V076CCIIU", "V076CCIIU", JdeDataType.String, 20),
        new JdeField("V076CAC01", "V076CAC01", JdeDataType.String, 6),
        new JdeField("V076CAC02", "V076CAC02", JdeDataType.String, 10),
        new JdeField("V076CAC03", "V076CAC03", JdeDataType.String, 16),
        new JdeField("V0URAB", "V0URAB", JdeDataType.Numeric),
        new JdeField("V0URDT", "V0URDT", JdeDataType.Numeric),
        new JdeField("V0URC1", "V0URC1", JdeDataType.String, 6),
        new JdeField("V0URRF", "V0URRF", JdeDataType.String, 30),
        new JdeField("V0USER", "V0USER", JdeDataType.String, 20),
        new JdeField("V0PID", "V0PID", JdeDataType.String, 20),
        new JdeField("V0JOBN", "V0JOBN", JdeDataType.String, 20),
        new JdeField("V0UPMJ", "V0UPMJ", JdeDataType.Numeric),
        new JdeField("V0UPMT", "V0UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76C0101_0", "Primary Key on V0AN8, V0EFDJ", new[] { "V0AN8", "V0EFDJ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76C0101_2", "Index on V076CTAX", new[] { "V076CTAX" })
    };
}
