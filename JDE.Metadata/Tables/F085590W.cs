using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F085590W - .
/// </summary>
public class F085590W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DSAN8.
        /// </summary>
        public const string DSAN8 = "DSAN8";

        /// <summary>
        /// DSALPH.
        /// </summary>
        public const string DSALPH = "DSALPH";

        /// <summary>
        /// DSHM04.
        /// </summary>
        public const string DSHM04 = "DSHM04";

        /// <summary>
        /// DSOFTP.
        /// </summary>
        public const string DSOFTP = "DSOFTP";

        /// <summary>
        /// DSEECD.
        /// </summary>
        public const string DSEECD = "DSEECD";

        /// <summary>
        /// DSEVET.
        /// </summary>
        public const string DSEVET = "DSEVET";

        /// <summary>
        /// DSFMIR.
        /// </summary>
        public const string DSFMIR = "DSFMIR";

        /// <summary>
        /// DSAT1.
        /// </summary>
        public const string DSAT1 = "DSAT1";

        /// <summary>
        /// DSACFL.
        /// </summary>
        public const string DSACFL = "DSACFL";

        /// <summary>
        /// DSESIGN.
        /// </summary>
        public const string DSESIGN = "DSESIGN";

        /// <summary>
        /// DSWFS.
        /// </summary>
        public const string DSWFS = "DSWFS";

        /// <summary>
        /// DSAPRV.
        /// </summary>
        public const string DSAPRV = "DSAPRV";

        /// <summary>
        /// DSAPRD.
        /// </summary>
        public const string DSAPRD = "DSAPRD";

        /// <summary>
        /// DSUPMJ.
        /// </summary>
        public const string DSUPMJ = "DSUPMJ";

        /// <summary>
        /// DSUPMT.
        /// </summary>
        public const string DSUPMT = "DSUPMT";

        /// <summary>
        /// DSPID.
        /// </summary>
        public const string DSPID = "DSPID";

        /// <summary>
        /// DSUSER.
        /// </summary>
        public const string DSUSER = "DSUSER";

        /// <summary>
        /// DSJOBN.
        /// </summary>
        public const string DSJOBN = "DSJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F085590W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DSAN8", "DSAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("DSALPH", "DSALPH", JdeDataType.String, 80),
        new JdeField("DSHM04", "DSHM04", JdeDataType.String, 2),
        new JdeField("DSOFTP", "DSOFTP", JdeDataType.String, 2),
        new JdeField("DSEECD", "DSEECD", JdeDataType.String, 6),
        new JdeField("DSEVET", "DSEVET", JdeDataType.Numeric),
        new JdeField("DSFMIR", "DSFMIR", JdeDataType.String, 2),
        new JdeField("DSAT1", "DSAT1", JdeDataType.String, 6),
        new JdeField("DSACFL", "DSACFL", JdeDataType.String, 2),
        new JdeField("DSESIGN", "DSESIGN", JdeDataType.String, 32),
        new JdeField("DSWFS", "DSWFS", JdeDataType.String, 2),
        new JdeField("DSAPRV", "DSAPRV", JdeDataType.Numeric),
        new JdeField("DSAPRD", "DSAPRD", JdeDataType.Numeric),
        new JdeField("DSUPMJ", "DSUPMJ", JdeDataType.Numeric),
        new JdeField("DSUPMT", "DSUPMT", JdeDataType.Numeric),
        new JdeField("DSPID", "DSPID", JdeDataType.String, 20),
        new JdeField("DSUSER", "DSUSER", JdeDataType.String, 20),
        new JdeField("DSJOBN", "DSJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F085590W_0", "Primary Key on DSAN8", new[] { "DSAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
