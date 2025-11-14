using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75A011T - .
/// </summary>
public class F75A011T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BWAN8.
        /// </summary>
        public const string BWAN8 = "BWAN8";

        /// <summary>
        /// BWDT.
        /// </summary>
        public const string BWDT = "BWDT";

        /// <summary>
        /// BWWPR83VAL.
        /// </summary>
        public const string BWWPR83VAL = "BWWPR83VAL";

        /// <summary>
        /// BWWPT83VAL.
        /// </summary>
        public const string BWWPT83VAL = "BWWPT83VAL";

        /// <summary>
        /// BWWASSAMT.
        /// </summary>
        public const string BWWASSAMT = "BWWASSAMT";

        /// <summary>
        /// BWWETPTAX.
        /// </summary>
        public const string BWWETPTAX = "BWWETPTAX";

        /// <summary>
        /// BWWEXCAMT.
        /// </summary>
        public const string BWWEXCAMT = "BWWEXCAMT";

        /// <summary>
        /// BWWNEXCAMT.
        /// </summary>
        public const string BWWNEXCAMT = "BWWNEXCAMT";

        /// <summary>
        /// BWSPADAUR1.
        /// </summary>
        public const string BWSPADAUR1 = "BWSPADAUR1";

        /// <summary>
        /// BWSPADAUR2.
        /// </summary>
        public const string BWSPADAUR2 = "BWSPADAUR2";

        /// <summary>
        /// BWSPADAUR3.
        /// </summary>
        public const string BWSPADAUR3 = "BWSPADAUR3";

        /// <summary>
        /// BWSPADAUR4.
        /// </summary>
        public const string BWSPADAUR4 = "BWSPADAUR4";

        /// <summary>
        /// BWSPAFAUR1.
        /// </summary>
        public const string BWSPAFAUR1 = "BWSPAFAUR1";

        /// <summary>
        /// BWSPAFAUR2.
        /// </summary>
        public const string BWSPAFAUR2 = "BWSPAFAUR2";

        /// <summary>
        /// BWSPAFAUR3.
        /// </summary>
        public const string BWSPAFAUR3 = "BWSPAFAUR3";

        /// <summary>
        /// BWSPAFAUR4.
        /// </summary>
        public const string BWSPAFAUR4 = "BWSPAFAUR4";

        /// <summary>
        /// BWSPASAUR1.
        /// </summary>
        public const string BWSPASAUR1 = "BWSPASAUR1";

        /// <summary>
        /// BWSPASAUR2.
        /// </summary>
        public const string BWSPASAUR2 = "BWSPASAUR2";

        /// <summary>
        /// BWSPASAUR3.
        /// </summary>
        public const string BWSPASAUR3 = "BWSPASAUR3";

        /// <summary>
        /// BWSPASAUR4.
        /// </summary>
        public const string BWSPASAUR4 = "BWSPASAUR4";

        /// <summary>
        /// BWSPANAUR1.
        /// </summary>
        public const string BWSPANAUR1 = "BWSPANAUR1";

        /// <summary>
        /// BWSPANAUR2.
        /// </summary>
        public const string BWSPANAUR2 = "BWSPANAUR2";

        /// <summary>
        /// BWSPANAUR3.
        /// </summary>
        public const string BWSPANAUR3 = "BWSPANAUR3";

        /// <summary>
        /// BWSPANAUR4.
        /// </summary>
        public const string BWSPANAUR4 = "BWSPANAUR4";

        /// <summary>
        /// BWSPANAUR5.
        /// </summary>
        public const string BWSPANAUR5 = "BWSPANAUR5";

        /// <summary>
        /// BWSPANAUR6.
        /// </summary>
        public const string BWSPANAUR6 = "BWSPANAUR6";

        /// <summary>
        /// BWSPANAUR7.
        /// </summary>
        public const string BWSPANAUR7 = "BWSPANAUR7";

        /// <summary>
        /// BWSPANAUR8.
        /// </summary>
        public const string BWSPANAUR8 = "BWSPANAUR8";

        /// <summary>
        /// BWSPANAUR9.
        /// </summary>
        public const string BWSPANAUR9 = "BWSPANAUR9";

        /// <summary>
        /// BWUSER.
        /// </summary>
        public const string BWUSER = "BWUSER";

        /// <summary>
        /// BWPID.
        /// </summary>
        public const string BWPID = "BWPID";

        /// <summary>
        /// BWUPMJ.
        /// </summary>
        public const string BWUPMJ = "BWUPMJ";

        /// <summary>
        /// BWJOBN.
        /// </summary>
        public const string BWJOBN = "BWJOBN";

        /// <summary>
        /// BWUPMT.
        /// </summary>
        public const string BWUPMT = "BWUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75A011T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BWAN8", "BWAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("BWDT", "BWDT", JdeDataType.Numeric, null, true, true),
        new JdeField("BWWPR83VAL", "BWWPR83VAL", JdeDataType.Numeric),
        new JdeField("BWWPT83VAL", "BWWPT83VAL", JdeDataType.Numeric),
        new JdeField("BWWASSAMT", "BWWASSAMT", JdeDataType.Numeric),
        new JdeField("BWWETPTAX", "BWWETPTAX", JdeDataType.Numeric),
        new JdeField("BWWEXCAMT", "BWWEXCAMT", JdeDataType.Numeric),
        new JdeField("BWWNEXCAMT", "BWWNEXCAMT", JdeDataType.Numeric),
        new JdeField("BWSPADAUR1", "BWSPADAUR1", JdeDataType.Numeric),
        new JdeField("BWSPADAUR2", "BWSPADAUR2", JdeDataType.Numeric),
        new JdeField("BWSPADAUR3", "BWSPADAUR3", JdeDataType.Numeric),
        new JdeField("BWSPADAUR4", "BWSPADAUR4", JdeDataType.Numeric),
        new JdeField("BWSPAFAUR1", "BWSPAFAUR1", JdeDataType.String, 2),
        new JdeField("BWSPAFAUR2", "BWSPAFAUR2", JdeDataType.String, 2),
        new JdeField("BWSPAFAUR3", "BWSPAFAUR3", JdeDataType.String, 2),
        new JdeField("BWSPAFAUR4", "BWSPAFAUR4", JdeDataType.String, 2),
        new JdeField("BWSPASAUR1", "BWSPASAUR1", JdeDataType.String, 60),
        new JdeField("BWSPASAUR2", "BWSPASAUR2", JdeDataType.String, 60),
        new JdeField("BWSPASAUR3", "BWSPASAUR3", JdeDataType.String, 60),
        new JdeField("BWSPASAUR4", "BWSPASAUR4", JdeDataType.String, 60),
        new JdeField("BWSPANAUR1", "BWSPANAUR1", JdeDataType.Numeric),
        new JdeField("BWSPANAUR2", "BWSPANAUR2", JdeDataType.Numeric),
        new JdeField("BWSPANAUR3", "BWSPANAUR3", JdeDataType.Numeric),
        new JdeField("BWSPANAUR4", "BWSPANAUR4", JdeDataType.Numeric),
        new JdeField("BWSPANAUR5", "BWSPANAUR5", JdeDataType.Numeric),
        new JdeField("BWSPANAUR6", "BWSPANAUR6", JdeDataType.Numeric),
        new JdeField("BWSPANAUR7", "BWSPANAUR7", JdeDataType.Numeric),
        new JdeField("BWSPANAUR8", "BWSPANAUR8", JdeDataType.Numeric),
        new JdeField("BWSPANAUR9", "BWSPANAUR9", JdeDataType.Numeric),
        new JdeField("BWUSER", "BWUSER", JdeDataType.String, 20),
        new JdeField("BWPID", "BWPID", JdeDataType.String, 20),
        new JdeField("BWUPMJ", "BWUPMJ", JdeDataType.Numeric),
        new JdeField("BWJOBN", "BWJOBN", JdeDataType.String, 20),
        new JdeField("BWUPMT", "BWUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75A011T_0", "Primary Key on BWAN8, BWDT", new[] { "BWAN8", "BWDT" }, isUnique: true, isPrimaryKey: true)
    };
}
