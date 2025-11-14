using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76C0F05 - .
/// </summary>
public class F76C0F05 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DSK74LECO.
        /// </summary>
        public const string DSK74LECO = "DSK74LECO";

        /// <summary>
        /// DSC76TAXM.
        /// </summary>
        public const string DSC76TAXM = "DSC76TAXM";

        /// <summary>
        /// DSC76DCTM.
        /// </summary>
        public const string DSC76DCTM = "DSC76DCTM";

        /// <summary>
        /// DSC76TAXS.
        /// </summary>
        public const string DSC76TAXS = "DSC76TAXS";

        /// <summary>
        /// DSC76DCTS.
        /// </summary>
        public const string DSC76DCTS = "DSC76DCTS";

        /// <summary>
        /// DSURCD.
        /// </summary>
        public const string DSURCD = "DSURCD";

        /// <summary>
        /// DSURRF.
        /// </summary>
        public const string DSURRF = "DSURRF";

        /// <summary>
        /// DSURDT.
        /// </summary>
        public const string DSURDT = "DSURDT";

        /// <summary>
        /// DSURAT.
        /// </summary>
        public const string DSURAT = "DSURAT";

        /// <summary>
        /// DSUSER.
        /// </summary>
        public const string DSUSER = "DSUSER";

        /// <summary>
        /// DSPID.
        /// </summary>
        public const string DSPID = "DSPID";

        /// <summary>
        /// DSJOBN.
        /// </summary>
        public const string DSJOBN = "DSJOBN";

        /// <summary>
        /// DSUPMJ.
        /// </summary>
        public const string DSUPMJ = "DSUPMJ";

        /// <summary>
        /// DSUPMT.
        /// </summary>
        public const string DSUPMT = "DSUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76C0F05";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DSK74LECO", "DSK74LECO", JdeDataType.String, 10, true, true),
        new JdeField("DSC76TAXM", "DSC76TAXM", JdeDataType.String, 40),
        new JdeField("DSC76DCTM", "DSC76DCTM", JdeDataType.Numeric),
        new JdeField("DSC76TAXS", "DSC76TAXS", JdeDataType.String, 40),
        new JdeField("DSC76DCTS", "DSC76DCTS", JdeDataType.Numeric),
        new JdeField("DSURCD", "DSURCD", JdeDataType.String, 4),
        new JdeField("DSURRF", "DSURRF", JdeDataType.String, 30),
        new JdeField("DSURDT", "DSURDT", JdeDataType.Numeric),
        new JdeField("DSURAT", "DSURAT", JdeDataType.Numeric),
        new JdeField("DSUSER", "DSUSER", JdeDataType.String, 20),
        new JdeField("DSPID", "DSPID", JdeDataType.String, 20),
        new JdeField("DSJOBN", "DSJOBN", JdeDataType.String, 20),
        new JdeField("DSUPMJ", "DSUPMJ", JdeDataType.Numeric),
        new JdeField("DSUPMT", "DSUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76C0F05_0", "Primary Key on DSK74LECO", new[] { "DSK74LECO" }, isUnique: true, isPrimaryKey: true)
    };
}
