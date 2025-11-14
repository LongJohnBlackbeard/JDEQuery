using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0626 - .
/// </summary>
public class F0626 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JGAN8.
        /// </summary>
        public const string JGAN8 = "JGAN8";

        /// <summary>
        /// JGPDBA.
        /// </summary>
        public const string JGPDBA = "JGPDBA";

        /// <summary>
        /// JGWANO.
        /// </summary>
        public const string JGWANO = "JGWANO";

        /// <summary>
        /// JGANN8.
        /// </summary>
        public const string JGANN8 = "JGANN8";

        /// <summary>
        /// JGOAN8.
        /// </summary>
        public const string JGOAN8 = "JGOAN8";

        /// <summary>
        /// JGWAFN.
        /// </summary>
        public const string JGWAFN = "JGWAFN";

        /// <summary>
        /// JGWACN.
        /// </summary>
        public const string JGWACN = "JGWACN";

        /// <summary>
        /// JGWACD.
        /// </summary>
        public const string JGWACD = "JGWACD";

        /// <summary>
        /// JGSSN.
        /// </summary>
        public const string JGSSN = "JGSSN";

        /// <summary>
        /// JGDL01.
        /// </summary>
        public const string JGDL01 = "JGDL01";

        /// <summary>
        /// JGAD.
        /// </summary>
        public const string JGAD = "JGAD";

        /// <summary>
        /// JGTARA.
        /// </summary>
        public const string JGTARA = "JGTARA";

        /// <summary>
        /// JGHMCO.
        /// </summary>
        public const string JGHMCO = "JGHMCO";

        /// <summary>
        /// JGPTCP.
        /// </summary>
        public const string JGPTCP = "JGPTCP";

        /// <summary>
        /// JGWADC.
        /// </summary>
        public const string JGWADC = "JGWADC";

        /// <summary>
        /// JGWATY.
        /// </summary>
        public const string JGWATY = "JGWATY";

        /// <summary>
        /// JGBAD.
        /// </summary>
        public const string JGBAD = "JGBAD";

        /// <summary>
        /// JGWADR.
        /// </summary>
        public const string JGWADR = "JGWADR";

        /// <summary>
        /// JGARRA.
        /// </summary>
        public const string JGARRA = "JGARRA";

        /// <summary>
        /// JGWAPN.
        /// </summary>
        public const string JGWAPN = "JGWAPN";

        /// <summary>
        /// JGWAMA.
        /// </summary>
        public const string JGWAMA = "JGWAMA";

        /// <summary>
        /// JGWADM.
        /// </summary>
        public const string JGWADM = "JGWADM";

        /// <summary>
        /// JGWAWA.
        /// </summary>
        public const string JGWAWA = "JGWAWA";

        /// <summary>
        /// JGWAAA.
        /// </summary>
        public const string JGWAAA = "JGWAAA";
    }

    /// <inheritdoc />
    public override string TableName => "F0626";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JGAN8", "JGAN8", JdeDataType.Numeric),
        new JdeField("JGPDBA", "JGPDBA", JdeDataType.Numeric),
        new JdeField("JGWANO", "JGWANO", JdeDataType.Numeric, null, true, true),
        new JdeField("JGANN8", "JGANN8", JdeDataType.Numeric),
        new JdeField("JGOAN8", "JGOAN8", JdeDataType.Numeric),
        new JdeField("JGWAFN", "JGWAFN", JdeDataType.String, 60),
        new JdeField("JGWACN", "JGWACN", JdeDataType.String, 60),
        new JdeField("JGWACD", "JGWACD", JdeDataType.Numeric),
        new JdeField("JGSSN", "JGSSN", JdeDataType.String, 40),
        new JdeField("JGDL01", "JGDL01", JdeDataType.String, 60),
        new JdeField("JGAD", "JGAD", JdeDataType.Numeric),
        new JdeField("JGTARA", "JGTARA", JdeDataType.String, 20),
        new JdeField("JGHMCO", "JGHMCO", JdeDataType.String, 10),
        new JdeField("JGPTCP", "JGPTCP", JdeDataType.String, 4),
        new JdeField("JGWADC", "JGWADC", JdeDataType.Numeric),
        new JdeField("JGWATY", "JGWATY", JdeDataType.String, 2),
        new JdeField("JGBAD", "JGBAD", JdeDataType.Numeric),
        new JdeField("JGWADR", "JGWADR", JdeDataType.Numeric),
        new JdeField("JGARRA", "JGARRA", JdeDataType.Numeric),
        new JdeField("JGWAPN", "JGWAPN", JdeDataType.Numeric),
        new JdeField("JGWAMA", "JGWAMA", JdeDataType.Numeric),
        new JdeField("JGWADM", "JGWADM", JdeDataType.String, 2),
        new JdeField("JGWAWA", "JGWAWA", JdeDataType.Numeric),
        new JdeField("JGWAAA", "JGWAAA", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0626_0", "Primary Key on JGWANO", new[] { "JGWANO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0626_2", "Index on JGAN8, JGANN8, JGOAN8, JGWANO", new[] { "JGAN8", "JGANN8", "JGOAN8", "JGWANO" }),
        new JdeIndex("F0626_3", "Index on JGANN8, JGOAN8, JGAN8, JGWANO", new[] { "JGANN8", "JGOAN8", "JGAN8", "JGWANO" }),
        new JdeIndex("F0626_4", "Index on JGOAN8, JGAN8, JGANN8, JGWANO", new[] { "JGOAN8", "JGAN8", "JGANN8", "JGWANO" })
    };
}
