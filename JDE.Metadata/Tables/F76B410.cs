using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B410 - .
/// </summary>
public class F76B410 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MWB76WTS.
        /// </summary>
        public const string MWB76WTS = "MWB76WTS";

        /// <summary>
        /// MWB76COID.
        /// </summary>
        public const string MWB76COID = "MWB76COID";

        /// <summary>
        /// MWBRG.
        /// </summary>
        public const string MWBRG = "MWBRG";

        /// <summary>
        /// MWEFTJ.
        /// </summary>
        public const string MWEFTJ = "MWEFTJ";

        /// <summary>
        /// MWB76MINA.
        /// </summary>
        public const string MWB76MINA = "MWB76MINA";

        /// <summary>
        /// MWCRCD.
        /// </summary>
        public const string MWCRCD = "MWCRCD";

        /// <summary>
        /// MWUSER.
        /// </summary>
        public const string MWUSER = "MWUSER";

        /// <summary>
        /// MWPID.
        /// </summary>
        public const string MWPID = "MWPID";

        /// <summary>
        /// MWJOBN.
        /// </summary>
        public const string MWJOBN = "MWJOBN";

        /// <summary>
        /// MWUPMJ.
        /// </summary>
        public const string MWUPMJ = "MWUPMJ";

        /// <summary>
        /// MWB76MET.
        /// </summary>
        public const string MWB76MET = "MWB76MET";

        /// <summary>
        /// MWUPMT.
        /// </summary>
        public const string MWUPMT = "MWUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B410";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MWB76WTS", "MWB76WTS", JdeDataType.String, 2, true, true),
        new JdeField("MWB76COID", "MWB76COID", JdeDataType.String, 18, true, true),
        new JdeField("MWBRG", "MWBRG", JdeDataType.String, 18, true, true),
        new JdeField("MWEFTJ", "MWEFTJ", JdeDataType.Numeric, null, true, true),
        new JdeField("MWB76MINA", "MWB76MINA", JdeDataType.Numeric),
        new JdeField("MWCRCD", "MWCRCD", JdeDataType.String, 6),
        new JdeField("MWUSER", "MWUSER", JdeDataType.String, 20),
        new JdeField("MWPID", "MWPID", JdeDataType.String, 20),
        new JdeField("MWJOBN", "MWJOBN", JdeDataType.String, 20),
        new JdeField("MWUPMJ", "MWUPMJ", JdeDataType.Numeric),
        new JdeField("MWB76MET", "MWB76MET", JdeDataType.String, 4),
        new JdeField("MWUPMT", "MWUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B410_0", "Primary Key on MWB76WTS, MWB76COID, MWBRG, MWEFTJ", new[] { "MWB76WTS", "MWB76COID", "MWBRG", "MWEFTJ" }, isUnique: true, isPrimaryKey: true)
    };
}
