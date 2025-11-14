using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0401T - .
/// </summary>
public class F0401T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VTAN8.
        /// </summary>
        public const string VTAN8 = "VTAN8";

        /// <summary>
        /// VTITMYN.
        /// </summary>
        public const string VTITMYN = "VTITMYN";

        /// <summary>
        /// VTPURYN.
        /// </summary>
        public const string VTPURYN = "VTPURYN";

        /// <summary>
        /// VTCO.
        /// </summary>
        public const string VTCO = "VTCO";

        /// <summary>
        /// VTMCU.
        /// </summary>
        public const string VTMCU = "VTMCU";

        /// <summary>
        /// VTFUSS1.
        /// </summary>
        public const string VTFUSS1 = "VTFUSS1";

        /// <summary>
        /// VTFUSS2.
        /// </summary>
        public const string VTFUSS2 = "VTFUSS2";

        /// <summary>
        /// VTFUSS3.
        /// </summary>
        public const string VTFUSS3 = "VTFUSS3";

        /// <summary>
        /// VTFUSS4.
        /// </summary>
        public const string VTFUSS4 = "VTFUSS4";

        /// <summary>
        /// VTFUSS5.
        /// </summary>
        public const string VTFUSS5 = "VTFUSS5";

        /// <summary>
        /// VTFUSN1.
        /// </summary>
        public const string VTFUSN1 = "VTFUSN1";

        /// <summary>
        /// VTFUSN2.
        /// </summary>
        public const string VTFUSN2 = "VTFUSN2";

        /// <summary>
        /// VTFUSN3.
        /// </summary>
        public const string VTFUSN3 = "VTFUSN3";

        /// <summary>
        /// VTFUSN4.
        /// </summary>
        public const string VTFUSN4 = "VTFUSN4";

        /// <summary>
        /// VTFUSN5.
        /// </summary>
        public const string VTFUSN5 = "VTFUSN5";

        /// <summary>
        /// VTUSER.
        /// </summary>
        public const string VTUSER = "VTUSER";

        /// <summary>
        /// VTPID.
        /// </summary>
        public const string VTPID = "VTPID";

        /// <summary>
        /// VTUPMJ.
        /// </summary>
        public const string VTUPMJ = "VTUPMJ";

        /// <summary>
        /// VTUPMT.
        /// </summary>
        public const string VTUPMT = "VTUPMT";

        /// <summary>
        /// VTJOBN.
        /// </summary>
        public const string VTJOBN = "VTJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F0401T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VTAN8", "VTAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("VTITMYN", "VTITMYN", JdeDataType.String, 2),
        new JdeField("VTPURYN", "VTPURYN", JdeDataType.String, 2),
        new JdeField("VTCO", "VTCO", JdeDataType.String, 10),
        new JdeField("VTMCU", "VTMCU", JdeDataType.String, 24),
        new JdeField("VTFUSS1", "VTFUSS1", JdeDataType.String, 60),
        new JdeField("VTFUSS2", "VTFUSS2", JdeDataType.String, 60),
        new JdeField("VTFUSS3", "VTFUSS3", JdeDataType.String, 60),
        new JdeField("VTFUSS4", "VTFUSS4", JdeDataType.String, 60),
        new JdeField("VTFUSS5", "VTFUSS5", JdeDataType.String, 60),
        new JdeField("VTFUSN1", "VTFUSN1", JdeDataType.Numeric),
        new JdeField("VTFUSN2", "VTFUSN2", JdeDataType.Numeric),
        new JdeField("VTFUSN3", "VTFUSN3", JdeDataType.Numeric),
        new JdeField("VTFUSN4", "VTFUSN4", JdeDataType.Numeric),
        new JdeField("VTFUSN5", "VTFUSN5", JdeDataType.Numeric),
        new JdeField("VTUSER", "VTUSER", JdeDataType.String, 20),
        new JdeField("VTPID", "VTPID", JdeDataType.String, 20),
        new JdeField("VTUPMJ", "VTUPMJ", JdeDataType.Numeric),
        new JdeField("VTUPMT", "VTUPMT", JdeDataType.Numeric),
        new JdeField("VTJOBN", "VTJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0401T_0", "Primary Key on VTAN8", new[] { "VTAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
