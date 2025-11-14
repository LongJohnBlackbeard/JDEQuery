using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F069160 - .
/// </summary>
public class F069160 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Y9AN8.
        /// </summary>
        public const string Y9AN8 = "Y9AN8";

        /// <summary>
        /// Y9CKCN.
        /// </summary>
        public const string Y9CKCN = "Y9CKCN";

        /// <summary>
        /// Y9DLVL.
        /// </summary>
        public const string Y9DLVL = "Y9DLVL";

        /// <summary>
        /// Y9PDBA.
        /// </summary>
        public const string Y9PDBA = "Y9PDBA";

        /// <summary>
        /// Y9WANO.
        /// </summary>
        public const string Y9WANO = "Y9WANO";

        /// <summary>
        /// Y9GPPL.
        /// </summary>
        public const string Y9GPPL = "Y9GPPL";

        /// <summary>
        /// Y9GMDL.
        /// </summary>
        public const string Y9GMDL = "Y9GMDL";

        /// <summary>
        /// Y9GQDL.
        /// </summary>
        public const string Y9GQDL = "Y9GQDL";

        /// <summary>
        /// Y9GADL.
        /// </summary>
        public const string Y9GADL = "Y9GADL";

        /// <summary>
        /// Y9GSAL.
        /// </summary>
        public const string Y9GSAL = "Y9GSAL";

        /// <summary>
        /// Y9GPPX.
        /// </summary>
        public const string Y9GPPX = "Y9GPPX";

        /// <summary>
        /// Y9GHMN.
        /// </summary>
        public const string Y9GHMN = "Y9GHMN";

        /// <summary>
        /// Y9GHMX.
        /// </summary>
        public const string Y9GHMX = "Y9GHMX";

        /// <summary>
        /// Y9USER.
        /// </summary>
        public const string Y9USER = "Y9USER";

        /// <summary>
        /// Y9PID.
        /// </summary>
        public const string Y9PID = "Y9PID";

        /// <summary>
        /// Y9JOBN.
        /// </summary>
        public const string Y9JOBN = "Y9JOBN";

        /// <summary>
        /// Y9UPMJ.
        /// </summary>
        public const string Y9UPMJ = "Y9UPMJ";

        /// <summary>
        /// Y9UPMT.
        /// </summary>
        public const string Y9UPMT = "Y9UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F069160";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Y9AN8", "Y9AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("Y9CKCN", "Y9CKCN", JdeDataType.Numeric, null, true, true),
        new JdeField("Y9DLVL", "Y9DLVL", JdeDataType.String, 2, true, true),
        new JdeField("Y9PDBA", "Y9PDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("Y9WANO", "Y9WANO", JdeDataType.Numeric, null, true, true),
        new JdeField("Y9GPPL", "Y9GPPL", JdeDataType.Numeric),
        new JdeField("Y9GMDL", "Y9GMDL", JdeDataType.Numeric),
        new JdeField("Y9GQDL", "Y9GQDL", JdeDataType.Numeric),
        new JdeField("Y9GADL", "Y9GADL", JdeDataType.Numeric),
        new JdeField("Y9GSAL", "Y9GSAL", JdeDataType.Numeric),
        new JdeField("Y9GPPX", "Y9GPPX", JdeDataType.Numeric),
        new JdeField("Y9GHMN", "Y9GHMN", JdeDataType.Numeric),
        new JdeField("Y9GHMX", "Y9GHMX", JdeDataType.Numeric),
        new JdeField("Y9USER", "Y9USER", JdeDataType.String, 20),
        new JdeField("Y9PID", "Y9PID", JdeDataType.String, 20),
        new JdeField("Y9JOBN", "Y9JOBN", JdeDataType.String, 20),
        new JdeField("Y9UPMJ", "Y9UPMJ", JdeDataType.Numeric),
        new JdeField("Y9UPMT", "Y9UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F069160_0", "Primary Key on Y9AN8, Y9CKCN, Y9DLVL, Y9PDBA, Y9WANO", new[] { "Y9AN8", "Y9CKCN", "Y9DLVL", "Y9PDBA", "Y9WANO" }, isUnique: true, isPrimaryKey: true)
    };
}
