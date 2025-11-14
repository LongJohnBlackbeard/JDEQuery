using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74Y170 - .
/// </summary>
public class F74Y170 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CTY74CTID.
        /// </summary>
        public const string CTY74CTID = "CTY74CTID";

        /// <summary>
        /// CTY74CTN.
        /// </summary>
        public const string CTY74CTN = "CTY74CTN";

        /// <summary>
        /// CTY74CTAL.
        /// </summary>
        public const string CTY74CTAL = "CTY74CTAL";

        /// <summary>
        /// CTY74CTTY.
        /// </summary>
        public const string CTY74CTTY = "CTY74CTTY";

        /// <summary>
        /// CTY74CPID.
        /// </summary>
        public const string CTY74CPID = "CTY74CPID";

        /// <summary>
        /// CTY74CPN.
        /// </summary>
        public const string CTY74CPN = "CTY74CPN";

        /// <summary>
        /// CTEFTJ.
        /// </summary>
        public const string CTEFTJ = "CTEFTJ";

        /// <summary>
        /// CTAN8.
        /// </summary>
        public const string CTAN8 = "CTAN8";

        /// <summary>
        /// CTTAX.
        /// </summary>
        public const string CTTAX = "CTTAX";

        /// <summary>
        /// CTY74SUMO.
        /// </summary>
        public const string CTY74SUMO = "CTY74SUMO";

        /// <summary>
        /// CTY74CAG.
        /// </summary>
        public const string CTY74CAG = "CTY74CAG";

        /// <summary>
        /// CTY74CSPL.
        /// </summary>
        public const string CTY74CSPL = "CTY74CSPL";

        /// <summary>
        /// CTY74CTAX.
        /// </summary>
        public const string CTY74CTAX = "CTY74CTAX";

        /// <summary>
        /// CTY74CATX.
        /// </summary>
        public const string CTY74CATX = "CTY74CATX";

        /// <summary>
        /// CTUSER.
        /// </summary>
        public const string CTUSER = "CTUSER";

        /// <summary>
        /// CTPID.
        /// </summary>
        public const string CTPID = "CTPID";

        /// <summary>
        /// CTUPMJ.
        /// </summary>
        public const string CTUPMJ = "CTUPMJ";

        /// <summary>
        /// CTUPMT.
        /// </summary>
        public const string CTUPMT = "CTUPMT";

        /// <summary>
        /// CTJOBN.
        /// </summary>
        public const string CTJOBN = "CTJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F74Y170";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CTY74CTID", "CTY74CTID", JdeDataType.Numeric, null, true, true),
        new JdeField("CTY74CTN", "CTY74CTN", JdeDataType.String, 30),
        new JdeField("CTY74CTAL", "CTY74CTAL", JdeDataType.String, 80),
        new JdeField("CTY74CTTY", "CTY74CTTY", JdeDataType.String, 4),
        new JdeField("CTY74CPID", "CTY74CPID", JdeDataType.Numeric),
        new JdeField("CTY74CPN", "CTY74CPN", JdeDataType.String, 30),
        new JdeField("CTEFTJ", "CTEFTJ", JdeDataType.Numeric),
        new JdeField("CTAN8", "CTAN8", JdeDataType.Numeric),
        new JdeField("CTTAX", "CTTAX", JdeDataType.String, 40),
        new JdeField("CTY74SUMO", "CTY74SUMO", JdeDataType.String, 2),
        new JdeField("CTY74CAG", "CTY74CAG", JdeDataType.Numeric),
        new JdeField("CTY74CSPL", "CTY74CSPL", JdeDataType.String, 2),
        new JdeField("CTY74CTAX", "CTY74CTAX", JdeDataType.Numeric),
        new JdeField("CTY74CATX", "CTY74CATX", JdeDataType.Numeric),
        new JdeField("CTUSER", "CTUSER", JdeDataType.String, 20),
        new JdeField("CTPID", "CTPID", JdeDataType.String, 20),
        new JdeField("CTUPMJ", "CTUPMJ", JdeDataType.Numeric),
        new JdeField("CTUPMT", "CTUPMT", JdeDataType.Numeric),
        new JdeField("CTJOBN", "CTJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74Y170_0", "Primary Key on CTY74CTID", new[] { "CTY74CTID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74Y170_2", "Index on CTY74CPID", new[] { "CTY74CPID" })
    };
}
