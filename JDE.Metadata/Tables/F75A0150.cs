using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75A0150 - .
/// </summary>
public class F75A0150 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ZDAN8.
        /// </summary>
        public const string ZDAN8 = "ZDAN8";

        /// <summary>
        /// ZDSPAFAUP1.
        /// </summary>
        public const string ZDSPAFAUP1 = "ZDSPAFAUP1";

        /// <summary>
        /// ZDSPADAUP1.
        /// </summary>
        public const string ZDSPADAUP1 = "ZDSPADAUP1";

        /// <summary>
        /// ZDSPADAUP2.
        /// </summary>
        public const string ZDSPADAUP2 = "ZDSPADAUP2";

        /// <summary>
        /// ZDDTEY.
        /// </summary>
        public const string ZDDTEY = "ZDDTEY";

        /// <summary>
        /// ZDUSER.
        /// </summary>
        public const string ZDUSER = "ZDUSER";

        /// <summary>
        /// ZDUPMJ.
        /// </summary>
        public const string ZDUPMJ = "ZDUPMJ";

        /// <summary>
        /// ZDUPMT.
        /// </summary>
        public const string ZDUPMT = "ZDUPMT";

        /// <summary>
        /// ZDPID.
        /// </summary>
        public const string ZDPID = "ZDPID";

        /// <summary>
        /// ZDJOBN.
        /// </summary>
        public const string ZDJOBN = "ZDJOBN";

        /// <summary>
        /// ZDSPFEDNM1.
        /// </summary>
        public const string ZDSPFEDNM1 = "ZDSPFEDNM1";

        /// <summary>
        /// ZDSPFEDNM2.
        /// </summary>
        public const string ZDSPFEDNM2 = "ZDSPFEDNM2";

        /// <summary>
        /// ZDSPFEDDT1.
        /// </summary>
        public const string ZDSPFEDDT1 = "ZDSPFEDDT1";

        /// <summary>
        /// ZDSPFEDDT2.
        /// </summary>
        public const string ZDSPFEDDT2 = "ZDSPFEDDT2";

        /// <summary>
        /// ZDSPFEDCH1.
        /// </summary>
        public const string ZDSPFEDCH1 = "ZDSPFEDCH1";

        /// <summary>
        /// ZDSPFEDCH2.
        /// </summary>
        public const string ZDSPFEDCH2 = "ZDSPFEDCH2";

        /// <summary>
        /// ZDSPFEDST1.
        /// </summary>
        public const string ZDSPFEDST1 = "ZDSPFEDST1";

        /// <summary>
        /// ZDSPFEDST2.
        /// </summary>
        public const string ZDSPFEDST2 = "ZDSPFEDST2";
    }

    /// <inheritdoc />
    public override string TableName => "F75A0150";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZDAN8", "ZDAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("ZDSPAFAUP1", "ZDSPAFAUP1", JdeDataType.String, 2, true, true),
        new JdeField("ZDSPADAUP1", "ZDSPADAUP1", JdeDataType.Numeric, null, true, true),
        new JdeField("ZDSPADAUP2", "ZDSPADAUP2", JdeDataType.Numeric),
        new JdeField("ZDDTEY", "ZDDTEY", JdeDataType.Numeric),
        new JdeField("ZDUSER", "ZDUSER", JdeDataType.String, 20),
        new JdeField("ZDUPMJ", "ZDUPMJ", JdeDataType.Numeric),
        new JdeField("ZDUPMT", "ZDUPMT", JdeDataType.Numeric),
        new JdeField("ZDPID", "ZDPID", JdeDataType.String, 20),
        new JdeField("ZDJOBN", "ZDJOBN", JdeDataType.String, 20),
        new JdeField("ZDSPFEDNM1", "ZDSPFEDNM1", JdeDataType.Numeric),
        new JdeField("ZDSPFEDNM2", "ZDSPFEDNM2", JdeDataType.Numeric),
        new JdeField("ZDSPFEDDT1", "ZDSPFEDDT1", JdeDataType.Numeric),
        new JdeField("ZDSPFEDDT2", "ZDSPFEDDT2", JdeDataType.Numeric),
        new JdeField("ZDSPFEDCH1", "ZDSPFEDCH1", JdeDataType.Numeric),
        new JdeField("ZDSPFEDCH2", "ZDSPFEDCH2", JdeDataType.Numeric),
        new JdeField("ZDSPFEDST1", "ZDSPFEDST1", JdeDataType.Numeric),
        new JdeField("ZDSPFEDST2", "ZDSPFEDST2", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75A0150_0", "Primary Key on ZDAN8, ZDSPAFAUP1, ZDSPADAUP1", new[] { "ZDAN8", "ZDSPAFAUP1", "ZDSPADAUP1" }, isUnique: true, isPrimaryKey: true)
    };
}
