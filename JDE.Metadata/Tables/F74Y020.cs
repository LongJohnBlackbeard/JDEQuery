using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74Y020 - .
/// </summary>
public class F74Y020 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IHY74IDEC.
        /// </summary>
        public const string IHY74IDEC = "IHY74IDEC";

        /// <summary>
        /// IHY74IPER.
        /// </summary>
        public const string IHY74IPER = "IHY74IPER";

        /// <summary>
        /// IHY74IPN.
        /// </summary>
        public const string IHY74IPN = "IHY74IPN";

        /// <summary>
        /// IHY74IYR.
        /// </summary>
        public const string IHY74IYR = "IHY74IYR";

        /// <summary>
        /// IHCO.
        /// </summary>
        public const string IHCO = "IHCO";

        /// <summary>
        /// IHY74IDEN.
        /// </summary>
        public const string IHY74IDEN = "IHY74IDEN";

        /// <summary>
        /// IHCTR.
        /// </summary>
        public const string IHCTR = "IHCTR";

        /// <summary>
        /// IHTAX.
        /// </summary>
        public const string IHTAX = "IHTAX";

        /// <summary>
        /// IHY74CUOF.
        /// </summary>
        public const string IHY74CUOF = "IHY74CUOF";

        /// <summary>
        /// IHY74IDEST.
        /// </summary>
        public const string IHY74IDEST = "IHY74IDEST";

        /// <summary>
        /// IHUSER.
        /// </summary>
        public const string IHUSER = "IHUSER";

        /// <summary>
        /// IHPID.
        /// </summary>
        public const string IHPID = "IHPID";

        /// <summary>
        /// IHJOBN.
        /// </summary>
        public const string IHJOBN = "IHJOBN";

        /// <summary>
        /// IHUPMJ.
        /// </summary>
        public const string IHUPMJ = "IHUPMJ";

        /// <summary>
        /// IHUPMT.
        /// </summary>
        public const string IHUPMT = "IHUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74Y020";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IHY74IDEC", "IHY74IDEC", JdeDataType.Numeric, null, true, true),
        new JdeField("IHY74IPER", "IHY74IPER", JdeDataType.String, 2),
        new JdeField("IHY74IPN", "IHY74IPN", JdeDataType.Numeric),
        new JdeField("IHY74IYR", "IHY74IYR", JdeDataType.Numeric),
        new JdeField("IHCO", "IHCO", JdeDataType.String, 10),
        new JdeField("IHY74IDEN", "IHY74IDEN", JdeDataType.String, 20),
        new JdeField("IHCTR", "IHCTR", JdeDataType.String, 6),
        new JdeField("IHTAX", "IHTAX", JdeDataType.String, 40),
        new JdeField("IHY74CUOF", "IHY74CUOF", JdeDataType.Numeric),
        new JdeField("IHY74IDEST", "IHY74IDEST", JdeDataType.String, 2),
        new JdeField("IHUSER", "IHUSER", JdeDataType.String, 20),
        new JdeField("IHPID", "IHPID", JdeDataType.String, 20),
        new JdeField("IHJOBN", "IHJOBN", JdeDataType.String, 20),
        new JdeField("IHUPMJ", "IHUPMJ", JdeDataType.Numeric),
        new JdeField("IHUPMT", "IHUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74Y020_0", "Primary Key on IHY74IDEC", new[] { "IHY74IDEC" }, isUnique: true, isPrimaryKey: true)
    };
}
