using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F085590 - .
/// </summary>
public class F085590 : JdeTable
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
        /// DSAT1.
        /// </summary>
        public const string DSAT1 = "DSAT1";

        /// <summary>
        /// DSHM04.
        /// </summary>
        public const string DSHM04 = "DSHM04";

        /// <summary>
        /// DSOFTP.
        /// </summary>
        public const string DSOFTP = "DSOFTP";

        /// <summary>
        /// DSMLDT.
        /// </summary>
        public const string DSMLDT = "DSMLDT";

        /// <summary>
        /// DSHM03.
        /// </summary>
        public const string DSHM03 = "DSHM03";

        /// <summary>
        /// DSHM02.
        /// </summary>
        public const string DSHM02 = "DSHM02";

        /// <summary>
        /// DSMUMJ.
        /// </summary>
        public const string DSMUMJ = "DSMUMJ";

        /// <summary>
        /// DSMUMT.
        /// </summary>
        public const string DSMUMT = "DSMUMT";

        /// <summary>
        /// DSFMIR.
        /// </summary>
        public const string DSFMIR = "DSFMIR";

        /// <summary>
        /// DSIDRT.
        /// </summary>
        public const string DSIDRT = "DSIDRT";

        /// <summary>
        /// DSEECD.
        /// </summary>
        public const string DSEECD = "DSEECD";

        /// <summary>
        /// DSEVET.
        /// </summary>
        public const string DSEVET = "DSEVET";

        /// <summary>
        /// DSESIGN.
        /// </summary>
        public const string DSESIGN = "DSESIGN";

        /// <summary>
        /// DSSARQ.
        /// </summary>
        public const string DSSARQ = "DSSARQ";

        /// <summary>
        /// DSSARS.
        /// </summary>
        public const string DSSARS = "DSSARS";

        /// <summary>
        /// DSSART.
        /// </summary>
        public const string DSSART = "DSSART";

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
    public override string TableName => "F085590";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DSAN8", "DSAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("DSALPH", "DSALPH", JdeDataType.String, 80),
        new JdeField("DSAT1", "DSAT1", JdeDataType.String, 6),
        new JdeField("DSHM04", "DSHM04", JdeDataType.String, 2),
        new JdeField("DSOFTP", "DSOFTP", JdeDataType.String, 2),
        new JdeField("DSMLDT", "DSMLDT", JdeDataType.Numeric),
        new JdeField("DSHM03", "DSHM03", JdeDataType.String, 2),
        new JdeField("DSHM02", "DSHM02", JdeDataType.String, 2),
        new JdeField("DSMUMJ", "DSMUMJ", JdeDataType.Numeric, null, true, true),
        new JdeField("DSMUMT", "DSMUMT", JdeDataType.Numeric, null, true, true),
        new JdeField("DSFMIR", "DSFMIR", JdeDataType.String, 2),
        new JdeField("DSIDRT", "DSIDRT", JdeDataType.String, 2, true, true),
        new JdeField("DSEECD", "DSEECD", JdeDataType.String, 6),
        new JdeField("DSEVET", "DSEVET", JdeDataType.Numeric),
        new JdeField("DSESIGN", "DSESIGN", JdeDataType.String, 32),
        new JdeField("DSSARQ", "DSSARQ", JdeDataType.String, 2),
        new JdeField("DSSARS", "DSSARS", JdeDataType.String, 2),
        new JdeField("DSSART", "DSSART", JdeDataType.Numeric),
        new JdeField("DSUPMJ", "DSUPMJ", JdeDataType.Numeric),
        new JdeField("DSUPMT", "DSUPMT", JdeDataType.Numeric),
        new JdeField("DSPID", "DSPID", JdeDataType.String, 20),
        new JdeField("DSUSER", "DSUSER", JdeDataType.String, 20),
        new JdeField("DSJOBN", "DSJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F085590_0", "Primary Key on DSAN8, DSMUMJ, DSMUMT, DSIDRT", new[] { "DSAN8", "DSMUMJ", "DSMUMT", "DSIDRT" }, isUnique: true, isPrimaryKey: true)
    };
}
