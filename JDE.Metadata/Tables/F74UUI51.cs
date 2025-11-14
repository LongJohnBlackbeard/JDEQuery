using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74UUI51 - .
/// </summary>
public class F74UUI51 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HMU74ICR.
        /// </summary>
        public const string HMU74ICR = "HMU74ICR";

        /// <summary>
        /// HMCO.
        /// </summary>
        public const string HMCO = "HMCO";

        /// <summary>
        /// HMDL01.
        /// </summary>
        public const string HMDL01 = "HMDL01";

        /// <summary>
        /// HMU74EMRE.
        /// </summary>
        public const string HMU74EMRE = "HMU74EMRE";

        /// <summary>
        /// HMU74UTR.
        /// </summary>
        public const string HMU74UTR = "HMU74UTR";

        /// <summary>
        /// HMUKCTR.
        /// </summary>
        public const string HMUKCTR = "HMUKCTR";

        /// <summary>
        /// HMU74NILR.
        /// </summary>
        public const string HMU74NILR = "HMU74NILR";

        /// <summary>
        /// HMU74EMSD.
        /// </summary>
        public const string HMU74EMSD = "HMU74EMSD";

        /// <summary>
        /// HMU74SCVD.
        /// </summary>
        public const string HMU74SCVD = "HMU74SCVD";

        /// <summary>
        /// HMU74INCD.
        /// </summary>
        public const string HMU74INCD = "HMU74INCD";

        /// <summary>
        /// HMU74ININ.
        /// </summary>
        public const string HMU74ININ = "HMU74ININ";

        /// <summary>
        /// HMU74TON.
        /// </summary>
        public const string HMU74TON = "HMU74TON";

        /// <summary>
        /// HMU74PEED.
        /// </summary>
        public const string HMU74PEED = "HMU74PEED";

        /// <summary>
        /// HMU74DMSG.
        /// </summary>
        public const string HMU74DMSG = "HMU74DMSG";

        /// <summary>
        /// HMU74TEIN.
        /// </summary>
        public const string HMU74TEIN = "HMU74TEIN";

        /// <summary>
        /// HMU74TRDA.
        /// </summary>
        public const string HMU74TRDA = "HMU74TRDA";

        /// <summary>
        /// HMU74TRTI.
        /// </summary>
        public const string HMU74TRTI = "HMU74TRTI";

        /// <summary>
        /// HMGPBT.
        /// </summary>
        public const string HMGPBT = "HMGPBT";

        /// <summary>
        /// HMGPTN.
        /// </summary>
        public const string HMGPTN = "HMGPTN";

        /// <summary>
        /// HMUSER.
        /// </summary>
        public const string HMUSER = "HMUSER";

        /// <summary>
        /// HMPID.
        /// </summary>
        public const string HMPID = "HMPID";

        /// <summary>
        /// HMUPMJ.
        /// </summary>
        public const string HMUPMJ = "HMUPMJ";

        /// <summary>
        /// HMUPMT.
        /// </summary>
        public const string HMUPMT = "HMUPMT";

        /// <summary>
        /// HMJOBN.
        /// </summary>
        public const string HMJOBN = "HMJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F74UUI51";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HMU74ICR", "HMU74ICR", JdeDataType.String, 28, true, true),
        new JdeField("HMCO", "HMCO", JdeDataType.String, 10),
        new JdeField("HMDL01", "HMDL01", JdeDataType.String, 60),
        new JdeField("HMU74EMRE", "HMU74EMRE", JdeDataType.String, 70),
        new JdeField("HMU74UTR", "HMU74UTR", JdeDataType.Numeric),
        new JdeField("HMUKCTR", "HMUKCTR", JdeDataType.String, 26),
        new JdeField("HMU74NILR", "HMU74NILR", JdeDataType.String, 2),
        new JdeField("HMU74EMSD", "HMU74EMSD", JdeDataType.String, 2),
        new JdeField("HMU74SCVD", "HMU74SCVD", JdeDataType.String, 2),
        new JdeField("HMU74INCD", "HMU74INCD", JdeDataType.String, 2),
        new JdeField("HMU74ININ", "HMU74ININ", JdeDataType.String, 2),
        new JdeField("HMU74TON", "HMU74TON", JdeDataType.Numeric),
        new JdeField("HMU74PEED", "HMU74PEED", JdeDataType.String, 70),
        new JdeField("HMU74DMSG", "HMU74DMSG", JdeDataType.String, 70),
        new JdeField("HMU74TEIN", "HMU74TEIN", JdeDataType.String, 2),
        new JdeField("HMU74TRDA", "HMU74TRDA", JdeDataType.Numeric),
        new JdeField("HMU74TRTI", "HMU74TRTI", JdeDataType.Numeric),
        new JdeField("HMGPBT", "HMGPBT", JdeDataType.Numeric),
        new JdeField("HMGPTN", "HMGPTN", JdeDataType.String, 28),
        new JdeField("HMUSER", "HMUSER", JdeDataType.String, 20),
        new JdeField("HMPID", "HMPID", JdeDataType.String, 20),
        new JdeField("HMUPMJ", "HMUPMJ", JdeDataType.Numeric),
        new JdeField("HMUPMT", "HMUPMT", JdeDataType.Numeric),
        new JdeField("HMJOBN", "HMJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74UUI51_0", "Primary Key on HMU74ICR", new[] { "HMU74ICR" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74UUI51_2", "Index on HMGPBT, HMGPTN", new[] { "HMGPBT", "HMGPTN" }),
        new JdeIndex("F74UUI51_3", "Index on HMU74PEED", new[] { "HMU74PEED" })
    };
}
