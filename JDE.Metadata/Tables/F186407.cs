using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F186407 - .
/// </summary>
public class F186407 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OBLRSORID.
        /// </summary>
        public const string OBLRSORID = "OBLRSORID";

        /// <summary>
        /// OBFCTNM.
        /// </summary>
        public const string OBFCTNM = "OBFCTNM";

        /// <summary>
        /// OBUSER.
        /// </summary>
        public const string OBUSER = "OBUSER";

        /// <summary>
        /// OBPID.
        /// </summary>
        public const string OBPID = "OBPID";

        /// <summary>
        /// OBJOBN.
        /// </summary>
        public const string OBJOBN = "OBJOBN";

        /// <summary>
        /// OBUPMJ.
        /// </summary>
        public const string OBUPMJ = "OBUPMJ";

        /// <summary>
        /// OBTDAY.
        /// </summary>
        public const string OBTDAY = "OBTDAY";

        /// <summary>
        /// OBVFL1.
        /// </summary>
        public const string OBVFL1 = "OBVFL1";

        /// <summary>
        /// OBVFL2.
        /// </summary>
        public const string OBVFL2 = "OBVFL2";

        /// <summary>
        /// OBVFL3.
        /// </summary>
        public const string OBVFL3 = "OBVFL3";

        /// <summary>
        /// OBVFL4.
        /// </summary>
        public const string OBVFL4 = "OBVFL4";

        /// <summary>
        /// OBVFL5.
        /// </summary>
        public const string OBVFL5 = "OBVFL5";

        /// <summary>
        /// OBVFL6.
        /// </summary>
        public const string OBVFL6 = "OBVFL6";

        /// <summary>
        /// OBUDD3.
        /// </summary>
        public const string OBUDD3 = "OBUDD3";

        /// <summary>
        /// OBUDD4.
        /// </summary>
        public const string OBUDD4 = "OBUDD4";

        /// <summary>
        /// OBUDD5.
        /// </summary>
        public const string OBUDD5 = "OBUDD5";

        /// <summary>
        /// OBUDD6.
        /// </summary>
        public const string OBUDD6 = "OBUDD6";

        /// <summary>
        /// OBUDD7.
        /// </summary>
        public const string OBUDD7 = "OBUDD7";

        /// <summary>
        /// OBUDD8.
        /// </summary>
        public const string OBUDD8 = "OBUDD8";

        /// <summary>
        /// OBDDA1.
        /// </summary>
        public const string OBDDA1 = "OBDDA1";

        /// <summary>
        /// OBDDA2.
        /// </summary>
        public const string OBDDA2 = "OBDDA2";

        /// <summary>
        /// OBDDA3.
        /// </summary>
        public const string OBDDA3 = "OBDDA3";

        /// <summary>
        /// OBDDA4.
        /// </summary>
        public const string OBDDA4 = "OBDDA4";

        /// <summary>
        /// OBDDA5.
        /// </summary>
        public const string OBDDA5 = "OBDDA5";

        /// <summary>
        /// OBDDA6.
        /// </summary>
        public const string OBDDA6 = "OBDDA6";

        /// <summary>
        /// OBLRSPTIF.
        /// </summary>
        public const string OBLRSPTIF = "OBLRSPTIF";

        /// <summary>
        /// OBUDCP.
        /// </summary>
        public const string OBUDCP = "OBUDCP";

        /// <summary>
        /// OBUDCB.
        /// </summary>
        public const string OBUDCB = "OBUDCB";

        /// <summary>
        /// OBUDDP.
        /// </summary>
        public const string OBUDDP = "OBUDDP";

        /// <summary>
        /// OBUDIP.
        /// </summary>
        public const string OBUDIP = "OBUDIP";

        /// <summary>
        /// OBUDSP.
        /// </summary>
        public const string OBUDSP = "OBUDSP";

        /// <summary>
        /// OBUDNP.
        /// </summary>
        public const string OBUDNP = "OBUDNP";
    }

    /// <inheritdoc />
    public override string TableName => "F186407";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OBLRSORID", "OBLRSORID", JdeDataType.Numeric, null, true, true),
        new JdeField("OBFCTNM", "OBFCTNM", JdeDataType.String, 64),
        new JdeField("OBUSER", "OBUSER", JdeDataType.String, 20),
        new JdeField("OBPID", "OBPID", JdeDataType.String, 20),
        new JdeField("OBJOBN", "OBJOBN", JdeDataType.String, 20),
        new JdeField("OBUPMJ", "OBUPMJ", JdeDataType.Numeric),
        new JdeField("OBTDAY", "OBTDAY", JdeDataType.Numeric),
        new JdeField("OBVFL1", "OBVFL1", JdeDataType.String, 2),
        new JdeField("OBVFL2", "OBVFL2", JdeDataType.String, 2),
        new JdeField("OBVFL3", "OBVFL3", JdeDataType.String, 2),
        new JdeField("OBVFL4", "OBVFL4", JdeDataType.String, 2),
        new JdeField("OBVFL5", "OBVFL5", JdeDataType.String, 2),
        new JdeField("OBVFL6", "OBVFL6", JdeDataType.String, 2),
        new JdeField("OBUDD3", "OBUDD3", JdeDataType.String, 40),
        new JdeField("OBUDD4", "OBUDD4", JdeDataType.String, 40),
        new JdeField("OBUDD5", "OBUDD5", JdeDataType.String, 40),
        new JdeField("OBUDD6", "OBUDD6", JdeDataType.String, 40),
        new JdeField("OBUDD7", "OBUDD7", JdeDataType.String, 40),
        new JdeField("OBUDD8", "OBUDD8", JdeDataType.String, 40),
        new JdeField("OBDDA1", "OBDDA1", JdeDataType.String, 20),
        new JdeField("OBDDA2", "OBDDA2", JdeDataType.String, 20),
        new JdeField("OBDDA3", "OBDDA3", JdeDataType.String, 20),
        new JdeField("OBDDA4", "OBDDA4", JdeDataType.String, 20),
        new JdeField("OBDDA5", "OBDDA5", JdeDataType.String, 20),
        new JdeField("OBDDA6", "OBDDA6", JdeDataType.String, 20),
        new JdeField("OBLRSPTIF", "OBLRSPTIF", JdeDataType.String, 2),
        new JdeField("OBUDCP", "OBUDCP", JdeDataType.String, 2),
        new JdeField("OBUDCB", "OBUDCB", JdeDataType.String, 2),
        new JdeField("OBUDDP", "OBUDDP", JdeDataType.Numeric),
        new JdeField("OBUDIP", "OBUDIP", JdeDataType.Numeric),
        new JdeField("OBUDSP", "OBUDSP", JdeDataType.String, 40),
        new JdeField("OBUDNP", "OBUDNP", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F186407_0", "Primary Key on OBLRSORID", new[] { "OBLRSORID" }, isUnique: true, isPrimaryKey: true)
    };
}
